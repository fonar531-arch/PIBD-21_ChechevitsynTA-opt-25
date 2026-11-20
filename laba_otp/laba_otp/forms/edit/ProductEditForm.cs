using System;
using System.Linq;
using System.Windows.Forms;

namespace otp_lab_25
{
    public partial class ProductEditForm : Form
    {
        private readonly IProductRepository _productRepo;
        private readonly ICategoryRepository _categoryRepo;
        private readonly Product _existingProduct;
        public ProductEditForm(IProductRepository productRepo, ICategoryRepository categoryRepo)
        {
            InitializeComponent();
            _productRepo = productRepo;
            _categoryRepo = categoryRepo;
            this.Text = "Добавление товара";
        }

        public ProductEditForm(IProductRepository productRepo, ICategoryRepository categoryRepo, Product product) : this(productRepo, categoryRepo)
        {
            _existingProduct = product;
            this.Text = "Редактирование товара";
        }

        private void ProductEditForm_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = _categoryRepo.GetAll().ToList();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";

            cmbType.DataSource = Enum.GetValues(typeof(ProductType));

            var conditions = Enum.GetValues(typeof(StorageConditions)).Cast<StorageConditions>().Where(c => c != StorageConditions.None);
            foreach (var condition in conditions)
            {
                clbStorage.Items.Add(condition);
            }

            if (_existingProduct != null)
            {
                txtName.Text = _existingProduct.Name;
                cmbCategory.SelectedValue = _existingProduct.CategoryId;
                cmbType.SelectedItem = _existingProduct.Type;
                numPrice.Value = _existingProduct.Price;
                numStockNorm.Value = _existingProduct.StockNorm;

                for (int i = 0; i < clbStorage.Items.Count; i++)
                {
                    var condition = (StorageConditions)clbStorage.Items[i];
                    if ((_existingProduct.StorageConditions & condition) == condition)
                    {
                        clbStorage.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                StorageConditions selectedConditions = StorageConditions.None;
                foreach (var item in clbStorage.CheckedItems)
                {
                    selectedConditions |= (StorageConditions)item;
                }

                string name = txtName.Text;
                int categoryId = (int)cmbCategory.SelectedValue;
                ProductType type = (ProductType)cmbType.SelectedItem;
                decimal price = numPrice.Value;
                int stockNorm = (int)numStockNorm.Value;

                if (_existingProduct == null)
                {
                    var newProduct = Product.Create(name, categoryId, type, price, stockNorm, selectedConditions);
                    _productRepo.Add(newProduct);
                }
                else
                {
                    _existingProduct.Update(name, categoryId, type, price, stockNorm, selectedConditions);
                    _productRepo.Update(_existingProduct);
                }

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