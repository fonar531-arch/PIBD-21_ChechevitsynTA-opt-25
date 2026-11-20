using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otp_lab_25;

public partial class ProductBatchForm : Form
{
    private readonly IProductBatchRepository _batchRepo;
    private readonly IProductRepository _productRepo;
    private readonly ISupplierRepository _supplierRepo;

    public ProductBatchForm(IProductBatchRepository batchRepo, IProductRepository productRepo, ISupplierRepository supplierRepo)
    {
        InitializeComponent();
        _batchRepo = batchRepo;
        _productRepo = productRepo;
        _supplierRepo = supplierRepo;
    }


    private void RefreshGrid()
    {
        var batches = _batchRepo.GetAll().Select(b => new
        {
            b.Id,
            Товар = _productRepo.GetById(b.ProductId)?.Name ?? "Неизвестно",
            Поставщик = _supplierRepo.GetById(b.SupplierId)?.Name ?? "Неизвестно",
            ДатаПрихода = b.ReceiptDate.ToShortDateString(),
            СрокГодности = b.ExpiryDate?.ToShortDateString() ?? "Без срока",
            Количество = b.Quantity,
            ЗакупочнаяЦена = b.PurchasePrice
        }).ToList();

        dgvBatches.DataSource = batches;
    }

    private void button_add_Click(object sender, EventArgs e)
    {
        using (var addForm = new ProductBatchAddForm(_batchRepo, _productRepo, _supplierRepo))
        {
            if (addForm.ShowDialog() == DialogResult.OK)
                RefreshGrid();
        }
    }

    private void ProductBatchForm_Load(object sender, EventArgs e)
    {
        RefreshGrid();
    }

    private void dgvBatches_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}
