namespace project19929
{
    partial class addremove
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
            FoodName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            FoodDate = new DateTimePicker();
            label3 = new Label();
            FoodCateg = new ComboBox();
            button1 = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            DelVal = new TextBox();
            button2 = new Button();
            FoodView = new DataGridView();
            button3 = new Button();
            label6 = new Label();
            fID = new TextBox();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FoodView).BeginInit();
            SuspendLayout();
            // 
            // FoodName
            // 
            FoodName.Location = new Point(164, 118);
            FoodName.Name = "FoodName";
            FoodName.Size = new Size(200, 23);
            FoodName.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SaddleBrown;
            label2.Location = new Point(55, 122);
            label2.Name = "label2";
            label2.Size = new Size(103, 19);
            label2.TabIndex = 11;
            label2.Text = "Food Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(11, 189);
            label1.Name = "label1";
            label1.Size = new Size(147, 19);
            label1.TabIndex = 12;
            label1.Text = "Food Date Added:";
            // 
            // FoodDate
            // 
            FoodDate.Location = new Point(164, 185);
            FoodDate.Name = "FoodDate";
            FoodDate.Size = new Size(200, 23);
            FoodDate.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SaddleBrown;
            label3.Location = new Point(29, 156);
            label3.Name = "label3";
            label3.Size = new Size(129, 19);
            label3.TabIndex = 14;
            label3.Text = "Food Category:";
            // 
            // FoodCateg
            // 
            FoodCateg.FormattingEnabled = true;
            FoodCateg.Items.AddRange(new object[] { "Raw Goods", "Dry Goods", "Ingredients" });
            FoodCateg.Location = new Point(164, 152);
            FoodCateg.Name = "FoodCateg";
            FoodCateg.Size = new Size(200, 23);
            FoodCateg.TabIndex = 15;
            FoodCateg.SelectedIndexChanged += FoodCateg_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(164, 214);
            button1.Name = "button1";
            button1.Size = new Size(90, 35);
            button1.TabIndex = 16;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGoldenrod;
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 77);
            panel1.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(20, 9);
            label4.Name = "label4";
            label4.Size = new Size(344, 56);
            label4.TabIndex = 18;
            label4.Text = "Add Inventory";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.SaddleBrown;
            label5.Location = new Point(55, 476);
            label5.Name = "label5";
            label5.Size = new Size(103, 19);
            label5.TabIndex = 19;
            label5.Text = "Food Name:";
            // 
            // DelVal
            // 
            DelVal.Location = new Point(164, 472);
            DelVal.Name = "DelVal";
            DelVal.Size = new Size(200, 23);
            DelVal.TabIndex = 18;
            // 
            // button2
            // 
            button2.Location = new Point(164, 501);
            button2.Name = "button2";
            button2.Size = new Size(90, 35);
            button2.TabIndex = 20;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FoodView
            // 
            FoodView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FoodView.Location = new Point(396, 111);
            FoodView.Name = "FoodView";
            FoodView.RowTemplate.Height = 25;
            FoodView.Size = new Size(440, 477);
            FoodView.TabIndex = 21;
            // 
            // button3
            // 
            button3.Location = new Point(164, 288);
            button3.Name = "button3";
            button3.Size = new Size(90, 35);
            button3.TabIndex = 22;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.SaddleBrown;
            label6.Location = new Point(85, 263);
            label6.Name = "label6";
            label6.Size = new Size(73, 19);
            label6.TabIndex = 24;
            label6.Text = "Food Id:";
            // 
            // fID
            // 
            fID.Location = new Point(164, 259);
            fID.Name = "fID";
            fID.Size = new Size(90, 23);
            fID.TabIndex = 23;
            fID.TextChanged += fID_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(12, 559);
            button4.Name = "button4";
            button4.Size = new Size(90, 35);
            button4.TabIndex = 25;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // addremove
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(857, 606);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(fID);
            Controls.Add(button3);
            Controls.Add(FoodView);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(DelVal);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(FoodCateg);
            Controls.Add(label3);
            Controls.Add(FoodDate);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(FoodName);
            Name = "addremove";
            Text = "addremove";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FoodView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FoodName;
        private Label label2;
        private Label label1;
        private DateTimePicker FoodDate;
        private Label label3;
        private ComboBox FoodCateg;
        private Button button1;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private TextBox DelVal;
        private Button button2;
        private DataGridView FoodView;
        private Button button3;
        private Label label6;
        private TextBox fID;
        private Button button4;
    }
}