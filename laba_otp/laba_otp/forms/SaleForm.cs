using System;
using System.Linq;
using System.Windows.Forms;

namespace otp_lab_25
{
    public partial class SaleForm : Form
    {
        private readonly ISaleRepository _saleRepo;
        private readonly IProductBatchRepository _batchRepo;
        private readonly IProductRepository _productRepo;

        public SaleForm(
            ISaleRepository saleRepo,
            IProductBatchRepository batchRepo,
            IProductRepository productRepo)
        {
            InitializeComponent();
            _saleRepo = saleRepo;
            _batchRepo = batchRepo;
            _productRepo = productRepo;
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            var sales = _saleRepo.GetAll().Select(s => new
            {
                s.Id,
                ДатаПродажи = s.SaleDate.ToString("g"),
                Сумма = s.GetTotalAmount(),
                КолВоТоваров = s.Items.Count
            }).ToList();

            dgvSales.DataSource = sales;
            if (dgvSales.Columns["Id"] != null)
                dgvSales.Columns["Id"].Visible = false;
        }


        private void button_add_Click(object sender, EventArgs e)
        {
            using (var addForm = new SaleAddForm(_saleRepo, _batchRepo, _productRepo))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                    RefreshGrid();
            }
        }
    }
}