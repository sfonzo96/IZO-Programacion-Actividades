namespace _24_04_03_Actividad_1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ProfilePic = new PictureBox();
            UploadPicBtn = new Button();
            ProfilePicLoader = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            calculadoraToolStripMenuItem1 = new ToolStripMenuItem();
            concatenadorToolStripMenuItem = new ToolStripMenuItem();
            NameLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)ProfilePic).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ProfilePic
            // 
            ProfilePic.Location = new Point(688, 43);
            ProfilePic.Name = "ProfilePic";
            ProfilePic.Size = new Size(50, 50);
            ProfilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            ProfilePic.TabIndex = 1;
            ProfilePic.TabStop = false;
            // 
            // UploadPicBtn
            // 
            UploadPicBtn.Location = new Point(686, 99);
            UploadPicBtn.Name = "UploadPicBtn";
            UploadPicBtn.Size = new Size(54, 23);
            UploadPicBtn.TabIndex = 2;
            UploadPicBtn.Text = "Nueva";
            UploadPicBtn.UseVisualStyleBackColor = true;
            UploadPicBtn.Click += UploadPicBtn_Click;
            // 
            // ProfilePicLoader
            // 
            ProfilePicLoader.Filter = "Image Files(*.JPEG;*.JPG)|*.JPEG;*.JPG";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { calculadoraToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculadoraToolStripMenuItem1, concatenadorToolStripMenuItem });
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(73, 20);
            calculadoraToolStripMenuItem.Text = "Funciones";
            // 
            // calculadoraToolStripMenuItem1
            // 
            calculadoraToolStripMenuItem1.Name = "calculadoraToolStripMenuItem1";
            calculadoraToolStripMenuItem1.Size = new Size(180, 22);
            calculadoraToolStripMenuItem1.Text = "Calculadora";
            calculadoraToolStripMenuItem1.Click += calculadoraToolStripMenuItem1_Click;
            // 
            // concatenadorToolStripMenuItem
            // 
            concatenadorToolStripMenuItem.Name = "concatenadorToolStripMenuItem";
            concatenadorToolStripMenuItem.Size = new Size(180, 22);
            concatenadorToolStripMenuItem.Text = "Concatenador";
            concatenadorToolStripMenuItem.Click += concatenadorToolStripMenuItem_Click;
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Location = new Point(628, 63);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(51, 15);
            NameLbl.TabIndex = 4;
            NameLbl.Text = "Nombre";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(NameLbl);
            Controls.Add(UploadPicBtn);
            Controls.Add(ProfilePic);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            ((System.ComponentModel.ISupportInitialize)ProfilePic).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox ProfilePic;
        private Button UploadPicBtn;
        private OpenFileDialog ProfilePicLoader;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem1;
        private ToolStripMenuItem concatenadorToolStripMenuItem;
        private Label NameLbl;
    }
}
