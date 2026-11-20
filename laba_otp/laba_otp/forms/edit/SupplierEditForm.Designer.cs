namespace otp_lab_25
{
    partial class SupplierEditForm
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
            SuspendLayout();
            // 
            // button_cancel
            // 
            button_cancel.DialogResult = DialogResult.Cancel;
            button_cancel.Location = new Point(258, 241);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(112, 34);
            button_cancel.TabIndex = 5;
            button_cancel.Text = "Отмена";
            button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            button_save.DialogResult = DialogResult.OK;
            button_save.Location = new Point(258, 175);
            button_save.Name = "button_save";
            button_save.Size = new Size(112, 34);
            button_save.TabIndex = 4;
            button_save.Text = "Сохранить";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(392, 209);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 3;
            // 
            // SupplierEditForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(txtName);
            Name = "SupplierEditForm";
            Text = "Изменение поставщика";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_cancel;
        private Button button_save;
        private TextBox txtName;
    }
}