namespace otp_lab_25
{
    partial class SupplierListForm
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
            button_delete = new Button();
            button_update = new Button();
            button_add = new Button();
            toolStrip1 = new ToolStrip();
            panel1 = new Panel();
            dgvSuppliers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            SuspendLayout();
            // 
            // button_delete
            // 
            button_delete.Location = new Point(29, 179);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(112, 34);
            button_delete.TabIndex = 11;
            button_delete.Text = "Удалить";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_update
            // 
            button_update.Location = new Point(29, 139);
            button_update.Name = "button_update";
            button_update.Size = new Size(112, 34);
            button_update.TabIndex = 10;
            button_update.Text = "Редактировать";
            button_update.UseVisualStyleBackColor = true;
            button_update.Click += button_update_Click;
            // 
            // button_add
            // 
            button_add.Location = new Point(29, 99);
            button_add.Name = "button_add";
            button_add.Size = new Size(112, 34);
            button_add.TabIndex = 9;
            button_add.Text = "Добавить";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 38);
            toolStrip1.TabIndex = 8;
            toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            panel1.Location = new Point(140, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 150);
            panel1.TabIndex = 7;
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Dock = DockStyle.Fill;
            dgvSuppliers.Location = new Point(0, 0);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.RowHeadersWidth = 62;
            dgvSuppliers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSuppliers.Size = new Size(800, 450);
            dgvSuppliers.TabIndex = 6;
            // 
            // SupplierListForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_delete);
            Controls.Add(button_update);
            Controls.Add(button_add);
            Controls.Add(toolStrip1);
            Controls.Add(panel1);
            Controls.Add(dgvSuppliers);
            Name = "SupplierListForm";
            Text = "Список поставщиков";
            Load += SupplierListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_delete;
        private Button button_update;
        private Button button_add;
        private ToolStrip toolStrip1;
        private Panel panel1;
        private DataGridView dgvSuppliers;
    }
}