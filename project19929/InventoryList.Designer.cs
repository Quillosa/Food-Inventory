namespace project19929
{
    partial class InventoryList
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
            dagview = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dagview).BeginInit();
            SuspendLayout();
            // 
            // dagview
            // 
            dagview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dagview.Location = new Point(12, 25);
            dagview.Name = "dagview";
            dagview.RowTemplate.Height = 25;
            dagview.Size = new Size(447, 536);
            dagview.TabIndex = 0;
            // 
            // InventoryList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(474, 614);
            Controls.Add(dagview);
            Name = "InventoryList";
            Text = "InventoryList";
            ((System.ComponentModel.ISupportInitialize)dagview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dagview;
    }
}