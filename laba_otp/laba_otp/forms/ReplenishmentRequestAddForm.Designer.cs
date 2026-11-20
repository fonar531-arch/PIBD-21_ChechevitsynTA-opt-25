namespace otp_lab_25
{
    partial class ReplenishmentRequestAddForm
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
            dtpRequestDate = new DateTimePicker();
            numQuantity = new NumericUpDown();
            button_save = new Button();
            button_cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // cmbProduct
            // 
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Location = new Point(64, 19);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(182, 33);
            cmbProduct.TabIndex = 0;
            // 
            // dtpRequestDate
            // 
            dtpRequestDate.Location = new Point(64, 75);
            dtpRequestDate.Name = "dtpRequestDate";
            dtpRequestDate.Size = new Size(300, 31);
            dtpRequestDate.TabIndex = 1;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(64, 135);
            numQuantity.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(180, 31);
            numQuantity.TabIndex = 2;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button_save
            // 
            button_save.DialogResult = DialogResult.OK;
            button_save.Location = new Point(64, 201);
            button_save.Name = "button_save";
            button_save.Size = new Size(112, 34);
            button_save.TabIndex = 3;
            button_save.Text = "Сохранить";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Location = new Point(205, 201);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(112, 34);
            button_cancel.TabIndex = 4;
            button_cancel.Text = "Отмена";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // ReplenishmentRequestAddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(numQuantity);
            Controls.Add(dtpRequestDate);
            Controls.Add(cmbProduct);
            Name = "ReplenishmentRequestAddForm";
            Text = "Добавление запроса на пополнение";
            Load += ReplenishmentRequestAddForm_Load;
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbProduct;
        private DateTimePicker dtpRequestDate;
        private NumericUpDown numQuantity;
        private Button button_save;
        private Button button_cancel;
    }
}