namespace _24_04_03_Actividad_1.Views
{
    partial class ConcatForm
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
            ConcatBtn = new Button();
            LastNameTxt = new TextBox();
            FullNameLbl = new Label();
            FirstNameTxt = new TextBox();
            NameLbl = new Label();
            SuspendLayout();
            // 
            // ConcatBtn
            // 
            ConcatBtn.Location = new Point(149, 183);
            ConcatBtn.Name = "ConcatBtn";
            ConcatBtn.Size = new Size(87, 23);
            ConcatBtn.TabIndex = 0;
            ConcatBtn.Text = "Concatenar";
            ConcatBtn.UseVisualStyleBackColor = true;
            ConcatBtn.Click += ConcatBtn_Click;
            // 
            // LastNameTxt
            // 
            LastNameTxt.Location = new Point(142, 89);
            LastNameTxt.Name = "LastNameTxt";
            LastNameTxt.Size = new Size(100, 23);
            LastNameTxt.TabIndex = 1;
            // 
            // FullNameLbl
            // 
            FullNameLbl.AutoSize = true;
            FullNameLbl.Font = new Font("Segoe UI", 12F);
            FullNameLbl.Location = new Point(154, 246);
            FullNameLbl.Name = "FullNameLbl";
            FullNameLbl.Size = new Size(77, 21);
            FullNameLbl.TabIndex = 2;
            FullNameLbl.Text = "FullName";
            // 
            // FirstNameTxt
            // 
            FirstNameTxt.Location = new Point(142, 131);
            FirstNameTxt.Name = "FirstNameTxt";
            FirstNameTxt.ReadOnly = true;
            FirstNameTxt.Size = new Size(100, 23);
            FirstNameTxt.TabIndex = 3;
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Location = new Point(322, 22);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(39, 15);
            NameLbl.TabIndex = 4;
            NameLbl.Text = "Name";
            // 
            // ConcatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(NameLbl);
            Controls.Add(FirstNameTxt);
            Controls.Add(FullNameLbl);
            Controls.Add(LastNameTxt);
            Controls.Add(ConcatBtn);
            Name = "ConcatForm";
            Text = "ConcatForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConcatBtn;
        private TextBox LastNameTxt;
        private Label FullNameLbl;
        private TextBox FirstNameTxt;
        private Label NameLbl;
    }
}