using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;


namespace fileBrower
{
    public partial class Form1 : MaterialForm
    {
        
        private bool isfile= false;
        private string currentSelecteditemName = "";
        private bool newder;
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void File_dt_time_Tick(object sender, EventArgs e)
        {
            if (ListRemovable())
            {
                Debug.WriteLine("detected");

            }
            else
            {
                Debug.WriteLine("No Drive");
            }

        }

        public void loadfilesAction()
        {
            loadfilesdirectories();
            isfile = false;
        }
        private void loadfilesdirectories()
        {
            string filepath = File_path_tb.Text;
            DirectoryInfo fileList;
            FileAttributes fileAttr;
            try
            {
                if (isfile)
                {
                    fileAttr = File.GetAttributes(filepath);
                }
                else
                {
                    fileAttr = File.GetAttributes(filepath);
                    
                }
                if (((fileAttr & FileAttributes.Directory) == FileAttributes.Directory) & !isfile)
                {

                    fileList = new DirectoryInfo(filepath + "/" + currentSelecteditemName);
                    File_path_tb.Text = fileList.ToString();
                    FileInfo[] files = fileList.GetFiles();
                    DirectoryInfo[] dirs = fileList.GetDirectories();
                    listView2.Clear();
                    for (int i = 0; i < dirs.Length; i++)
                    {

                        listView2.Items.Add(dirs[i].Name, 5);
                    }
                    for (int i = 0; i < files.Length; i++)
                    {
                        string extention = Path.GetExtension(files[i].Name);

                        switch (extention)
                        {
                            case ".pdf":
                                listView2.Items.Add(files[i].Name, 0);
                                break;
                            case ".docx":
                                listView2.Items.Add(files[i].Name, 6);
                                break;
                        }
                    }
                    currentSelecteditemName = "";
                }

               
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
        }


        private bool ListRemovable()
        {

            foreach (DriveInfo d in DriveInfo.GetDrives())
            {
                if (d.IsReady && d.DriveType == DriveType.Removable)
                {
                    return true;
                }

            }
            return false;
        }
        private string getDrivePath()
        {
            foreach (DriveInfo d in DriveInfo.GetDrives())
            {
                if (d.IsReady && d.DriveType == DriveType.Removable)
                {
                    string root = d.RootDirectory.Name;
                    root = root.Remove(2, 1);
                    return root;
                }
            }
            return "";
        }

        private void listView2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                string filepath = File_path_tb.Text;
                currentSelecteditemName = e.Item.Text;
                Debug.WriteLine(currentSelecteditemName);
                FileAttributes fileAttr = File.GetAttributes(filepath + "/" + currentSelecteditemName);
                if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    isfile = false;
                }
                else
                {
                    isfile = true;
                }
            }
            catch (Exception t)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File_dt_time.Start();
            File_path_tb.Text = getDrivePath();
            loadfilesAction();
            File_path_tb.Text = getDrivePath();
        }

        private void listView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             loadfilesAction();
        }

        private void listView2_ItemDrag(object sender, ItemDragEventArgs e)
        {
            string extention = Path.GetExtension(File_path_tb.Text + currentSelecteditemName);

            if (extention == ".pdf" || extention == ".docx") {
                // create array or collection for all selected items
                var items = new List<ListViewItem>();
                // add dragged one first
                items.Add((ListViewItem)e.Item);
                // optionally add the other selected ones
                foreach (ListViewItem lvi in listView3.SelectedItems)
                {
                    if (!items.Contains(lvi))
                    {
                        items.Add(lvi);
                    }
                }
                // pass the items to move...
                listView3.DoDragDrop(items, DragDropEffects.Move);
            }

        }

        private void listView3_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listView3_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));
                // move to dest LV
                foreach (ListViewItem lvi in items)
                {
                    // LVI obj can only belong to one LVI, remove
                    lvi.ListView.Items.Remove(lvi);
                    listView3.Items.Add(lvi);
                }
            }
        }


        private void listView3_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            String itemname = e.Item.Text;
            string itemTag = e.Item.Tag.ToString().Remove(2,2);
            
        }

        private void listView2_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            Debug.WriteLine("Selected");
        }

        //GO BACK
        private void removeStach()
        {
            string path = File_path_tb.Text;
            if (path.LastIndexOf("/") == path.Length -1)
            {
                File_path_tb.Text = path.Substring(0, path.Length - 2);
            }
        }
        private void back_bt_Click(object sender, EventArgs e)
        {
            try
            {
                removeStach();
                String path = File_path_tb.Text;
                path = path.Substring(0, path.LastIndexOf("/"));
                File_path_tb.Text = path;
                loadfilesAction();
            }
            catch (Exception t)
            {

            }
        }
    }
}
