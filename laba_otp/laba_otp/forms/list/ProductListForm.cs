using System;
using System.Linq;
using System.Windows.Forms;

namespace otp_lab_25
{
    public partial class ProductListForm : Form
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductListForm(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            InitializeComponent();
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }
        private void ProductListForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            var products = _productRepository.GetAll().Select(p => new
            {
                p.Id,
                p.Name,
                Категория = _categoryRepository.GetById(p.CategoryId)?.Name ?? "Неизвестно",
                Тип = p.Type.ToString(),
                Цена = p.Price,
                НормаОстатка = p.StockNorm,
                УсловияХранения = p.StorageConditions.ToString()
            }).ToList();

            dgvProducts.DataSource = products;

            if (dgvProducts.Columns["Id"] != null)
                dgvProducts.Columns["Id"].Visible = false;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            using (var editForm = new ProductEditForm(_productRepository, _categoryRepository))
            {
                if (editForm.ShowDialog() == DialogResult.OK) { }
                RefreshGrid();
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите продукт для редактирования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedId = (int)dgvProducts.SelectedRows[0].Cells["Id"].Value;
            var fullProduct = _productRepository.GetById(selectedId);

            if (fullProduct != null)
            {
                using (var editForm = new ProductEditForm(_productRepository, _categoryRepository, fullProduct))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                        RefreshGrid();
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите продукт для удаления.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedId = (int)dgvProducts.SelectedRows[0].Cells["Id"].Value;
            var selectedName = dgvProducts.SelectedRows[0].Cells["Имя"].Value?.ToString() ?? "";

            if (MessageBox.Show($"Удалить товар '{selectedName}'?", "Подтверждение",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    _productRepository.Delete(selectedId);
                    RefreshGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удалось удалить товар: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}