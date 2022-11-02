namespace fileBrower
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Icon_list = new System.Windows.Forms.ImageList(this.components);
            this.listView3 = new System.Windows.Forms.ListView();
            this.File_dt_time = new System.Windows.Forms.Timer(this.components);
            this.File_path_tb = new MaterialSkin.Controls.MaterialTextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.back_bt = new MaterialSkin.Controls.MaterialButton();
            this.Done = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // Icon_list
            // 
            this.Icon_list.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Icon_list.ImageStream")));
            this.Icon_list.TransparentColor = System.Drawing.Color.Transparent;
            this.Icon_list.Images.SetKeyName(0, "pdf-icon-3.png");
            this.Icon_list.Images.SetKeyName(1, "oldword.png");
            this.Icon_list.Images.SetKeyName(2, "word.png");
            this.Icon_list.Images.SetKeyName(3, "folder.png");
            this.Icon_list.Images.SetKeyName(4, "unknowFile.png");
            this.Icon_list.Images.SetKeyName(5, "folder-invoices.png");
            this.Icon_list.Images.SetKeyName(6, "wordi.ico");
            // 
            // listView3
            // 
            this.listView3.AllowDrop = true;
            this.listView3.CausesValidation = false;
            this.listView3.HideSelection = false;
            this.listView3.LargeImageList = this.Icon_list;
            this.listView3.Location = new System.Drawing.Point(545, 93);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(243, 349);
            this.listView3.SmallImageList = this.Icon_list;
            this.listView3.TabIndex = 3;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView3_DragDrop);
            this.listView3.DragOver += new System.Windows.Forms.DragEventHandler(this.listView3_DragOver);
            // 
            // File_dt_time
            // 
            this.File_dt_time.Interval = 1000;
            this.File_dt_time.Tick += new System.EventHandler(this.File_dt_time_Tick);
            // 
            // File_path_tb
            // 
            this.File_path_tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.File_path_tb.Depth = 0;
            this.File_path_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.File_path_tb.LeadingIcon = null;
            this.File_path_tb.Location = new System.Drawing.Point(34, 83);
            this.File_path_tb.MaxLength = 50;
            this.File_path_tb.MouseState = MaterialSkin.MouseState.OUT;
            this.File_path_tb.Multiline = false;
            this.File_path_tb.Name = "File_path_tb";
            this.File_path_tb.Size = new System.Drawing.Size(494, 50);
            this.File_path_tb.TabIndex = 10;
            this.File_path_tb.Text = "";
            this.File_path_tb.TrailingIcon = null;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.listView2.HideSelection = false;
            this.listView2.LargeImageList = this.Icon_list;
            this.listView2.Location = new System.Drawing.Point(34, 139);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(494, 303);
            this.listView2.TabIndex = 11;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listView2_ItemDrag);
            this.listView2.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView2_ItemSelectionChanged);
            this.listView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseDoubleClick);
            // 
            // back_bt
            // 
            this.back_bt.AutoSize = false;
            this.back_bt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.back_bt.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.back_bt.Depth = 0;
            this.back_bt.HighEmphasis = true;
            this.back_bt.Icon = null;
            this.back_bt.Location = new System.Drawing.Point(455, 448);
            this.back_bt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.back_bt.MouseState = MaterialSkin.MouseState.HOVER;
            this.back_bt.Name = "back_bt";
            this.back_bt.Size = new System.Drawing.Size(73, 29);
            this.back_bt.TabIndex = 12;
            this.back_bt.Text = "<<";
            this.back_bt.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.back_bt.UseAccentColor = false;
            this.back_bt.UseVisualStyleBackColor = true;
            this.back_bt.Click += new System.EventHandler(this.back_bt_Click);
            // 
            // Done
            // 
            this.Done.AutoSize = false;
            this.Done.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Done.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.Done.Depth = 0;
            this.Done.HighEmphasis = true;
            this.Done.Icon = null;
            this.Done.Location = new System.Drawing.Point(715, 448);
            this.Done.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Done.MouseState = MaterialSkin.MouseState.HOVER;
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(73, 29);
            this.Done.TabIndex = 13;
            this.Done.Text = "<<";
            this.Done.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.Done.UseAccentColor = false;
            this.Done.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.back_bt);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.File_path_tb);
            this.Controls.Add(this.listView3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList Icon_list;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Timer File_dt_time;
        private MaterialSkin.Controls.MaterialTextBox File_path_tb;
        private System.Windows.Forms.ListView listView2;
        private MaterialSkin.Controls.MaterialButton back_bt;
        private MaterialSkin.Controls.MaterialButton Done;
    }
}

