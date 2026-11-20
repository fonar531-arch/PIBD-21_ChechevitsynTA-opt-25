namespace otp_lab_25
{
    partial class ProductBatchAddForm
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
            cmbProduct = new ComboBox();
            cmbSupplier = new ComboBox();
            chkHasExpiry = new CheckBox();
            dtpReceiptDate = new DateTimePicker();
            dtpExpiryDate = new DateTimePicker();
            numQuantity = new NumericUpDown();
            numPrice = new NumericUpDown();
            button_save = new Button();
            button_cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            SuspendLayout();
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(70, 23);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(182, 33);
            cmbProduct.TabIndex = 0;
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(293, 23);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(182, 33);
            cmbSupplier.TabIndex = 1;
            // 
            // chkHasExpiry
            // 
            chkHasExpiry.AutoSize = true;
            chkHasExpiry.Location = new Point(401, 142);
            chkHasExpiry.Name = "chkHasExpiry";
            chkHasExpiry.Size = new Size(159, 29);
            chkHasExpiry.TabIndex = 2;
            chkHasExpiry.Text = "Срок годности";
            chkHasExpiry.UseVisualStyleBackColor = true;
            chkHasExpiry.CheckedChanged += chkHasExpiry_CheckedChanged;
            // 
            // dtpReceiptDate
            // 
            dtpReceiptDate.Location = new Point(70, 80);
            dtpReceiptDate.Name = "dtpReceiptDate";
            dtpReceiptDate.Size = new Size(300, 31);
            dtpReceiptDate.TabIndex = 3;
            // 
            // dtpExpiryDate
            // 
            dtpExpiryDate.Location = new Point(70, 138);
            dtpExpiryDate.Name = "dtpExpiryDate";
            dtpExpiryDate.Size = new Size(300, 31);
            dtpExpiryDate.TabIndex = 4;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(70, 196);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(180, 31);
            numQuantity.TabIndex = 5;
            // 
            // numPrice
            // 
            numPrice.Location = new Point(70, 253);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(180, 31);
            numPrice.TabIndex = 6;
            // 
            // button_save
            // 
            button_save.Location = new Point(70, 305);
            button_save.Name = "button_save";
            button_save.Size = new Size(112, 34);
            button_save.TabIndex = 7;
            button_save.Text = "Сохранить";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Location = new Point(188, 305);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(112, 34);
            button_cancel.TabIndex = 8;
            button_cancel.Text = "Отмена";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // ProductBatchAddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(numPrice);
            Controls.Add(numQuantity);
            Controls.Add(dtpExpiryDate);
            Controls.Add(dtpReceiptDate);
            Controls.Add(chkHasExpiry);
            Controls.Add(cmbSupplier);
            Controls.Add(cmbProduct);
            Name = "ProductBatchAddForm";
            Text = "Добавление партии товаров";
            Load += ProductBatchAddForm_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProduct;
        private ComboBox cmbSupplier;
        private CheckBox chkHasExpiry;
        private DateTimePicker dtpReceiptDate;
        private DateTimePicker dtpExpiryDate;
        private NumericUpDown numQuantity;
        private NumericUpDown numPrice;
        private Button button_save;
        private Button button_cancel;
    }
}