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
    public partial class ReplenishmentRequestForm : Form
    {
        private readonly IReplenishmentRequestRepository _requestRepo;
        private readonly IProductRepository _productRepo;

        public ReplenishmentRequestForm(IReplenishmentRequestRepository requestRepo, IProductRepository productRepo)
        {
            InitializeComponent();
            _requestRepo = requestRepo;
            _productRepo = productRepo;
        }

        private void RefreshGrid()
        {
            var requests = _requestRepo.GetAll().Select(r => new
            {
                r.Id,
                Товар = _productRepo.GetById(r.ProductId)?.Name ?? "Неизвестно",
                ДатаЗаявки = r.RequestDate.ToShortDateString(),
                Количество = r.Quantity,
                Статус = r.Status.ToString()
            }).ToList();

            dgvRequests.DataSource = requests;
        }

        private void ReplenishmentRequestForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            using (var addForm = new ReplenishmentRequestAddForm(_requestRepo, _productRepo))
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                    RefreshGrid();
            }
        }
    }
}
