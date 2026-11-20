using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otp_lab_25
{
    public partial class ProductBatchAddForm : Form
    {
        private readonly IProductBatchRepository _batchRepo;
        private readonly IProductRepository _productRepo;
        private readonly ISupplierRepository _supplierRepo;
        public ProductBatchAddForm(IProductBatchRepository batchRepo, IProductRepository productRepo, ISupplierRepository supplierRepo)
        {
            InitializeComponent();
            _batchRepo = batchRepo;
            _productRepo = productRepo;
            _supplierRepo = supplierRepo;
        }

        private void ProductBatchAddForm_Load(object sender, EventArgs e)
        {
            cmbProduct.DataSource = _productRepo.GetAll().ToList();
            cmbProduct.DisplayMember = "Name";
            cmbProduct.ValueMember = "Id";

            cmbSupplier.DataSource = _supplierRepo.GetAll().ToList();
            cmbSupplier.DisplayMember = "Name";
            cmbSupplier.ValueMember = "Id";

            dtpExpiryDate.Enabled = false;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProduct.SelectedValue == null || cmbSupplier.SelectedValue == null)
                    throw new Exception("Выберите товар и поставщика.");

                var batch = ProductBatch.Create(
                    (int)cmbProduct.SelectedValue,
                    (int)cmbSupplier.SelectedValue,
                    dtpReceiptDate.Value,
                    chkHasExpiry.Checked ? dtpExpiryDate.Value : (DateTime?)null,
                    (int)numQuantity.Value,
                    numPrice.Value
                );

                _batchRepo.Add(batch);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkHasExpiry_CheckedChanged(object sender, EventArgs e)
        {
            dtpExpiryDate.Enabled = chkHasExpiry.Checked;

        }
    }
}
