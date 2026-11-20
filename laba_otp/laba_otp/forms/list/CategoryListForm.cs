using System;
using System.Linq;
using System.Windows;
using System.Windows.Forms;

namespace otp_lab_25
{
    public partial class CategoryListForm : Form
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryListForm(ICategoryRepository categoryRepository)
        {
            InitializeComponent();
            _categoryRepository = categoryRepository;
        }

        private void CategoryListForm_Load_1(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgvCategories.DataSource = null;
            dgvCategories.DataSource = _categoryRepository.GetAll().ToList();

            if (dgvCategories.Columns["Id"] != null)
                dgvCategories.Columns["Id"].Visible = false;

            if (dgvCategories.Columns["Name"] != null)
                dgvCategories.Columns["Name"].HeaderText = "Название категории";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
             using (var editForm = new CategoryEditForm(_categoryRepository))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите категорию для редактирования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedCategory = dgvCategories.SelectedRows[0].DataBoundItem as Category;

            if (selectedCategory != null)
            {
                using (var editForm = new CategoryEditForm(_categoryRepository, selectedCategory))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        RefreshGrid();
                    }
                }
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите категорию для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedCategory = dgvCategories.SelectedRows[0].DataBoundItem as Category;

            if (selectedCategory != null)
            {
                var result = MessageBox.Show($"Удалить категорию '{selectedCategory.Name}'?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _categoryRepository.Delete(selectedCategory.Id);
                        RefreshGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

    }
}