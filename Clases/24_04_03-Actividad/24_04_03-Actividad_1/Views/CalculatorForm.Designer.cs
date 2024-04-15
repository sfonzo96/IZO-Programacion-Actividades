namespace _24_04_03_Actividad_1.Views
{
    partial class CalculatorForm
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
            FirstValueTxt = new TextBox();
            SecondValueTxt = new TextBox();
            ResultLbl = new Label();
            AddBtn = new Button();
            SubsBtn = new Button();
            DivBtn = new Button();
            MultBtn = new Button();
            NameLbl = new Label();
            SuspendLayout();
            // 
            // FirstValueTxt
            // 
            FirstValueTxt.Location = new Point(142, 99);
            FirstValueTxt.Name = "FirstValueTxt";
            FirstValueTxt.Size = new Size(100, 23);
            FirstValueTxt.TabIndex = 0;
            // 
            // SecondValueTxt
            // 
            SecondValueTxt.Location = new Point(142, 153);
            SecondValueTxt.Name = "SecondValueTxt";
            SecondValueTxt.Size = new Size(100, 23);
            SecondValueTxt.TabIndex = 1;
            // 
            // ResultLbl
            // 
            ResultLbl.AutoSize = true;
            ResultLbl.Font = new Font("Segoe UI", 12F);
            ResultLbl.Location = new Point(153, 270);
            ResultLbl.Name = "ResultLbl";
            ResultLbl.Size = new Size(79, 21);
            ResultLbl.TabIndex = 2;
            ResultLbl.Text = "Resultado";
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(33, 210);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 3;
            AddBtn.Text = "+";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // SubsBtn
            // 
            SubsBtn.Location = new Point(114, 210);
            SubsBtn.Name = "SubsBtn";
            SubsBtn.Size = new Size(75, 23);
            SubsBtn.TabIndex = 4;
            SubsBtn.Text = "-";
            SubsBtn.UseVisualStyleBackColor = true;
            SubsBtn.Click += SubsBtn_Click;
            // 
            // DivBtn
            // 
            DivBtn.Location = new Point(195, 210);
            DivBtn.Name = "DivBtn";
            DivBtn.Size = new Size(75, 23);
            DivBtn.TabIndex = 5;
            DivBtn.Text = "/";
            DivBtn.UseVisualStyleBackColor = true;
            DivBtn.Click += DivBtn_Click;
            // 
            // MultBtn
            // 
            MultBtn.Location = new Point(276, 210);
            MultBtn.Name = "MultBtn";
            MultBtn.Size = new Size(75, 23);
            MultBtn.TabIndex = 6;
            MultBtn.Text = "*";
            MultBtn.UseVisualStyleBackColor = true;
            MultBtn.Click += MultBtn_Click;
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.Location = new Point(322, 22);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(39, 15);
            NameLbl.TabIndex = 7;
            NameLbl.Text = "Name";
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(NameLbl);
            Controls.Add(MultBtn);
            Controls.Add(DivBtn);
            Controls.Add(SubsBtn);
            Controls.Add(AddBtn);
            Controls.Add(ResultLbl);
            Controls.Add(SecondValueTxt);
            Controls.Add(FirstValueTxt);
            Name = "CalculatorForm";
            Text = "CalculatorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FirstValueTxt;
        private TextBox SecondValueTxt;
        private Label ResultLbl;
        private Button AddBtn;
        private Button SubsBtn;
        private Button DivBtn;
        private Button MultBtn;
        private Label NameLbl;
    }
}