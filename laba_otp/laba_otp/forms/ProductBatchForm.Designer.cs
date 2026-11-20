namespace otp_lab_25
{
    partial class ProductBatchForm
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
            button_add = new Button();
            dgvBatches = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBatches).BeginInit();
            SuspendLayout();
            // 
            // button_add
            // 
            button_add.Location = new Point(676, 12);
            button_add.Name = "button_add";
            button_add.Size = new Size(112, 34);
            button_add.TabIndex = 1;
            button_add.Text = "Добавить";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // dgvBatches
            // 
            dgvBatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatches.Location = new Point(0, 0);
            dgvBatches.Name = "dgvBatches";
            dgvBatches.RowHeadersWidth = 62;
            dgvBatches.Size = new Size(670, 450);
            dgvBatches.TabIndex = 2;
            dgvBatches.CellContentClick += dgvBatches_CellContentClick;
            // 
            // ProductBatchForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_add);
            Controls.Add(dgvBatches);
            Name = "ProductBatchForm";
            Text = "Партии товаров";
            Load += ProductBatchForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBatches).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button_add;
        private DataGridView dgvBatches;
    }
}