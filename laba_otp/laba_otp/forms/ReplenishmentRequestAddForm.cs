using System;
using System.Linq;
using System.Windows.Forms;

namespace otp_lab_25
{
    public partial class ReplenishmentRequestAddForm : Form
    {
        private readonly IReplenishmentRequestRepository _requestRepo;
        private readonly IProductRepository _productRepo;

        public ReplenishmentRequestAddForm(
            IReplenishmentRequestRepository requestRepo,
            IProductRepository productRepo)
        {
            InitializeComponent();
            _requestRepo = requestRepo;
            _productRepo = productRepo;
        }
        private void ReplenishmentRequestAddForm_Load(object sender, EventArgs e)
        {
            var products = _productRepo.GetAll().ToList();

            if (products.Count == 0)
            {
                MessageBox.Show("В базе нет товаров. Сначала добавьте товары в справочник.",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            cmbProduct.DataSource = products;
            cmbProduct.DisplayMember = "Name"; 
            cmbProduct.ValueMember = "Id";    
            dtpRequestDate.Value = DateTime.Now;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbProduct.SelectedValue == null)
                    throw new Exception("Необходимо выбрать товар из списка.");

                int productId = (int)cmbProduct.SelectedValue;
                DateTime requestDate = dtpRequestDate.Value;
                int quantity = (int)numQuantity.Value;

                var request = ReplenishmentRequest.Create(
                    productId,
                    requestDate,
                    quantity,
                    RequestStatus.New);
                _requestRepo.Add(request);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}