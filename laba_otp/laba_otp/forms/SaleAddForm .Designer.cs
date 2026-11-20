namespace otp_lab_25
{
    partial class SaleAddForm
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
            dtpSaleDate = new DateTimePicker();
            dgvBatches = new DataGridView();
            numQuantity = new NumericUpDown();
            button_Add_Cart = new Button();
            dgvCart = new DataGridView();
            lblTotal = new Label();
            button_save = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBatches).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            SuspendLayout();
            // 
            // dtpSaleDate
            // 
            dtpSaleDate.Location = new Point(65, 24);
            dtpSaleDate.Name = "dtpSaleDate";
            dtpSaleDate.Size = new Size(300, 31);
            dtpSaleDate.TabIndex = 0;
            // 
            // dgvBatches
            // 
            dgvBatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatches.Location = new Point(67, 74);
            dgvBatches.Name = "dgvBatches";
            dgvBatches.RowHeadersWidth = 62;
            dgvBatches.Size = new Size(360, 225);
            dgvBatches.TabIndex = 1;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(65, 316);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(180, 31);
            numQuantity.TabIndex = 2;
            // 
            // button_Add_Cart
            // 
            button_Add_Cart.Location = new Point(101, 367);
            button_Add_Cart.Name = "button_Add_Cart";
            button_Add_Cart.Size = new Size(273, 34);
            button_Add_Cart.TabIndex = 3;
            button_Add_Cart.Text = "Добавить в чек";
            button_Add_Cart.UseVisualStyleBackColor = true;
            button_Add_Cart.Click += button_Add_Cart_Click;
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(452, 74);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 62;
            dgvCart.Size = new Size(336, 225);
            dgvCart.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(452, 322);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(155, 25);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Итоговая сумма: ";
            // 
            // button_save
            // 
            button_save.Location = new Point(452, 367);
            button_save.Name = "button_save";
            button_save.Size = new Size(138, 34);
            button_save.TabIndex = 6;
            button_save.Text = "Сохранить";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // SaleAddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_save);
            Controls.Add(lblTotal);
            Controls.Add(dgvCart);
            Controls.Add(button_Add_Cart);
            Controls.Add(numQuantity);
            Controls.Add(dgvBatches);
            Controls.Add(dtpSaleDate);
            Name = "SaleAddForm";
            Text = "Добавление продажи";
            Load += SaleAddForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBatches).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpSaleDate;
        private DataGridView dgvBatches;
        private NumericUpDown numQuantity;
        private Button button_Add_Cart;
        private DataGridView dgvCart;
        private Label lblTotal;
        private Button button_save;
    }
}