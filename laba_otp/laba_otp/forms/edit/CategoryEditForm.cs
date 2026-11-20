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
    public partial class CategoryEditForm : Form
    {
        private readonly ICategoryRepository _repository;
        private readonly Category _existingCategory;
        public CategoryEditForm(ICategoryRepository repository)
        {
            InitializeComponent();
            _repository = repository;
            this.Text = "Добавление категории";
        }
        public CategoryEditForm(ICategoryRepository repository, Category category) : this(repository)
        {
            _existingCategory = category;
            this.Text = "Редактирование категории";
            txtName.Text = _existingCategory.Name;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (_existingCategory == null)
                {
                    var newCategory = Category.Create(txtName.Text);
                    _repository.Add(newCategory);
                }
                else 
                {
                    _existingCategory.UpdateName(txtName.Text);
                    _repository.Update(_existingCategory);
                }

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
