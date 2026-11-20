namespace otp_lab_25
{
    partial class ProductEditForm
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
            button_cancel = new Button();
            button_save = new Button();
            txtName = new TextBox();
            cmbCategory = new ComboBox();
            cmbType = new ComboBox();
            numPrice = new NumericUpDown();
            numStockNorm = new NumericUpDown();
            clbStorage = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStockNorm).BeginInit();
            SuspendLayout();
            // 
            // button_cancel
            // 
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Location = new Point(357, 189);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(112, 34);
            button_cancel.TabIndex = 5;
            button_cancel.Text = "Отмена";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            button_save.Location = new Point(224, 189);
            button_save.Name = "button_save";
            button_save.Size = new Size(112, 34);
            button_save.TabIndex = 4;
            button_save.Text = "Сохранить";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(29, 28);
            txtName.Name = "txtName";
            txtName.Size = new Size(431, 31);
            txtName.TabIndex = 3;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(29, 76);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(201, 33);
            cmbCategory.TabIndex = 6;
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(259, 76);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(201, 33);
            cmbType.TabIndex = 7;
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(29, 130);
            numPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(201, 31);
            numPrice.TabIndex = 8;
            // 
            // numStockNorm
            // 
            numStockNorm.Location = new Point(259, 130);
            numStockNorm.Name = "numStockNorm";
            numStockNorm.Size = new Size(201, 31);
            numStockNorm.TabIndex = 9;
            // 
            // clbStorage
            // 
            clbStorage.CheckOnClick = true;
            clbStorage.FormattingEnabled = true;
            clbStorage.Location = new Point(29, 189);
            clbStorage.Name = "clbStorage";
            clbStorage.Size = new Size(180, 116);
            clbStorage.TabIndex = 10;
            // 
            // ProductEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clbStorage);
            Controls.Add(numStockNorm);
            Controls.Add(numPrice);
            Controls.Add(cmbType);
            Controls.Add(cmbCategory);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(txtName);
            Name = "ProductEditForm";
            Text = "Изменение продукта";
            Load += ProductEditForm_Load;
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStockNorm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_cancel;
        private Button button_save;
        private TextBox txtName;
        private ComboBox cmbCategory;
        private ComboBox cmbType;
        private NumericUpDown numPrice;
        private NumericUpDown numStockNorm;
        private CheckedListBox clbStorage;
    }
}