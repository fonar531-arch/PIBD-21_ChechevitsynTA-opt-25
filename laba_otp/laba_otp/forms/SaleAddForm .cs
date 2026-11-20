using System;
using System.Linq;
using System.Windows.Forms;

namespace otp_lab_25
{
    public partial class SaleAddForm : Form
    {
        private readonly ISaleRepository _saleRepo;
        private readonly IProductBatchRepository _batchRepo;
        private readonly IProductRepository _productRepo;

        private Sale _currentSale;

        public SaleAddForm(
            ISaleRepository saleRepo,
            IProductBatchRepository batchRepo,
            IProductRepository productRepo)
        {
            InitializeComponent();
            _saleRepo = saleRepo;
            _batchRepo = batchRepo;
            _productRepo = productRepo;
        }

        private void SaleAddForm_Load(object sender, EventArgs e)
        {
            _currentSale = Sale.Create(dtpSaleDate.Value);
            LoadAvailableBatches();
        }

        private void LoadAvailableBatches()
        {
            var batches = _batchRepo.GetAll()
                .Where(b => b.Quantity > 0)
                .Select(b => new
                {
                    b.Id,
                    Товар = _productRepo.GetById(b.ProductId)?.Name ?? "Неизвестно",
                    Остаток = b.Quantity,
                    Цена = _productRepo.GetById(b.ProductId)?.Price ?? 0
                }).ToList();

            dgvBatches.DataSource = batches;
            if (dgvBatches.Columns["Id"] != null)
                dgvBatches.Columns["Id"].Visible = false;
        }

        private void button_Add_Cart_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBatches.SelectedRows.Count == 0)
                    throw new Exception("Выберите партию товара.");

                int batchId = (int)dgvBatches.SelectedRows[0].Cells["Id"].Value;
                int availableQty = (int)dgvBatches.SelectedRows[0].Cells["Остаток"].Value;
                int requestedQty = (int)numQuantity.Value;
                decimal price = (decimal)dgvBatches.SelectedRows[0].Cells["Цена"].Value;

                if (requestedQty > availableQty)
                    throw new Exception($"В партии осталось только {availableQty} шт.");

                _currentSale.AddItem(0, batchId, requestedQty, price);
                RefreshCart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshCart()
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = _currentSale.Items.Select(i => new
            {
                ID_Партии = i.ProductBatchId,
                Количество = i.Quantity,
                Цена = i.UnitPrice,
                Сумма = i.GetTotal()
            }).ToList();

            lblTotal.Text = $"Итого: {_currentSale.GetTotalAmount()} руб.";
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (_currentSale.Items.Count == 0)
                    throw new Exception("Чек пуст. Добавьте хотя бы один товар.");

                _saleRepo.Add(_currentSale);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}