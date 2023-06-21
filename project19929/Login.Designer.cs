namespace project19929
{
    partial class Login
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
            loginBTN = new Button();
            passtb = new TextBox();
            nametb = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // loginBTN
            // 
            loginBTN.Location = new Point(141, 193);
            loginBTN.Name = "loginBTN";
            loginBTN.Size = new Size(94, 23);
            loginBTN.TabIndex = 8;
            loginBTN.Text = "Login";
            loginBTN.UseVisualStyleBackColor = true;
            loginBTN.Click += loginBTN_Click;
            // 
            // passtb
            // 
            passtb.Location = new Point(116, 164);
            passtb.Name = "passtb";
            passtb.Size = new Size(145, 23);
            passtb.TabIndex = 7;
            // 
            // nametb
            // 
            nametb.Location = new Point(116, 135);
            nametb.Name = "nametb";
            nametb.Size = new Size(145, 23);
            nametb.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGoldenrod;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 98);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(66, 9);
            label1.Name = "label1";
            label1.Size = new Size(235, 75);
            label1.TabIndex = 1;
            label1.Text = "LOGIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(51, 139);
            label2.Name = "label2";
            label2.Size = new Size(55, 19);
            label2.TabIndex = 10;
            label2.Text = "USER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(52, 166);
            label3.Name = "label3";
            label3.Size = new Size(52, 19);
            label3.TabIndex = 11;
            label3.Text = "PASS";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(352, 320);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(loginBTN);
            Controls.Add(passtb);
            Controls.Add(nametb);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginBTN;
        private TextBox passtb;
        private TextBox nametb;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}