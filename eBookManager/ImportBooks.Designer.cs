namespace eBookManager
{
    partial class ImportBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportBooks));
            this.btnSelectSourceFolder = new System.Windows.Forms.Button();
            this.tvFoundBooks = new System.Windows.Forms.TreeView();
            this.cbVirtualStorageSpaces = new System.Windows.Forms.ComboBox();
            this.btnAddNewStorageSpace = new System.Windows.Forms.Button();
            this.btnSaveNewStorageSpace = new System.Windows.Forms.Button();
            this.btnAddBookToStaorageSpace = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.dtCreated = new System.Windows.Forms.DateTimePicker();
            this.dtLastAccessed = new System.Windows.Forms.DateTimePicker();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtFileSize = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelectSourceFolder
            // 
            this.btnSelectSourceFolder.Location = new System.Drawing.Point(34, 22);
            this.btnSelectSourceFolder.Name = "btnSelectSourceFolder";
            this.btnSelectSourceFolder.Size = new System.Drawing.Size(145, 29);
            this.btnSelectSourceFolder.TabIndex = 0;
            this.btnSelectSourceFolder.Text = "Select Source Folder";
            this.btnSelectSourceFolder.UseVisualStyleBackColor = true;
            this.btnSelectSourceFolder.Click += new System.EventHandler(this.btnSelectSourceFolder_Click);
            // 
            // tvFoundBooks
            // 
            this.tvFoundBooks.Location = new System.Drawing.Point(34, 57);
            this.tvFoundBooks.Name = "tvFoundBooks";
            this.tvFoundBooks.Size = new System.Drawing.Size(536, 330);
            this.tvFoundBooks.TabIndex = 1;
            this.tvFoundBooks.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvFoundBooks_AfterSelect);
            // 
            // cbVirtualStorageSpaces
            // 
            this.cbVirtualStorageSpaces.FormattingEnabled = true;
            this.cbVirtualStorageSpaces.Location = new System.Drawing.Point(34, 428);
            this.cbVirtualStorageSpaces.Name = "cbVirtualStorageSpaces";
            this.cbVirtualStorageSpaces.Size = new System.Drawing.Size(206, 23);
            this.cbVirtualStorageSpaces.TabIndex = 2;
            // 
            // btnAddNewStorageSpace
            // 
            this.btnAddNewStorageSpace.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewStorageSpace.Image")));
            this.btnAddNewStorageSpace.Location = new System.Drawing.Point(246, 428);
            this.btnAddNewStorageSpace.Name = "btnAddNewStorageSpace";
            this.btnAddNewStorageSpace.Size = new System.Drawing.Size(70, 73);
            this.btnAddNewStorageSpace.TabIndex = 3;
            this.btnAddNewStorageSpace.UseVisualStyleBackColor = true;
            // 
            // btnSaveNewStorageSpace
            // 
            this.btnSaveNewStorageSpace.Location = new System.Drawing.Point(505, 399);
            this.btnSaveNewStorageSpace.Name = "btnSaveNewStorageSpace";
            this.btnSaveNewStorageSpace.Size = new System.Drawing.Size(65, 23);
            this.btnSaveNewStorageSpace.TabIndex = 4;
            this.btnSaveNewStorageSpace.Text = "Save";
            this.btnSaveNewStorageSpace.UseVisualStyleBackColor = true;
            // 
            // btnAddBookToStaorageSpace
            // 
            this.btnAddBookToStaorageSpace.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBookToStaorageSpace.Image")));
            this.btnAddBookToStaorageSpace.Location = new System.Drawing.Point(505, 428);
            this.btnAddBookToStaorageSpace.Name = "btnAddBookToStaorageSpace";
            this.btnAddBookToStaorageSpace.Size = new System.Drawing.Size(65, 73);
            this.btnAddBookToStaorageSpace.TabIndex = 5;
            this.btnAddBookToStaorageSpace.UseVisualStyleBackColor = true;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(162, 23);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(236, 23);
            this.txtFileName.TabIndex = 6;
            // 
            // txtExtension
            // 
            this.txtExtension.Location = new System.Drawing.Point(162, 52);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(236, 23);
            this.txtExtension.TabIndex = 7;
            // 
            // dtCreated
            // 
            this.dtCreated.Location = new System.Drawing.Point(162, 81);
            this.dtCreated.Name = "dtCreated";
            this.dtCreated.Size = new System.Drawing.Size(236, 23);
            this.dtCreated.TabIndex = 8;
            // 
            // dtLastAccessed
            // 
            this.dtLastAccessed.Location = new System.Drawing.Point(162, 110);
            this.dtLastAccessed.Name = "dtLastAccessed";
            this.dtLastAccessed.Size = new System.Drawing.Size(236, 23);
            this.dtLastAccessed.TabIndex = 9;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(162, 139);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(236, 23);
            this.txtFilePath.TabIndex = 10;
            // 
            // txtFileSize
            // 
            this.txtFileSize.Location = new System.Drawing.Point(162, 168);
            this.txtFileSize.Name = "txtFileSize";
            this.txtFileSize.Size = new System.Drawing.Size(236, 23);
            this.txtFileSize.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFileSize);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.txtFilePath);
            this.groupBox1.Controls.Add(this.txtExtension);
            this.groupBox1.Controls.Add(this.dtLastAccessed);
            this.groupBox1.Controls.Add(this.dtCreated);
            this.groupBox1.Location = new System.Drawing.Point(576, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 207);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Details";
            // 
            // ImportBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 620);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddBookToStaorageSpace);
            this.Controls.Add(this.btnSaveNewStorageSpace);
            this.Controls.Add(this.btnAddNewStorageSpace);
            this.Controls.Add(this.cbVirtualStorageSpaces);
            this.Controls.Add(this.tvFoundBooks);
            this.Controls.Add(this.btnSelectSourceFolder);
            this.Name = "ImportBooks";
            this.Text = "ImportBooks";
            this.Load += new System.EventHandler(this.ImportBooks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectSourceFolder;
        private System.Windows.Forms.TreeView tvFoundBooks;
        private System.Windows.Forms.ComboBox cbVirtualStorageSpaces;
        private System.Windows.Forms.Button btnAddNewStorageSpace;
        private System.Windows.Forms.Button btnSaveNewStorageSpace;
        private System.Windows.Forms.Button btnAddBookToStaorageSpace;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.DateTimePicker dtCreated;
        private System.Windows.Forms.DateTimePicker dtLastAccessed;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtFileSize;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}