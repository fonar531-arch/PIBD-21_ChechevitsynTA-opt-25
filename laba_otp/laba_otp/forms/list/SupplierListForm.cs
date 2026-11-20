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
    public partial class SupplierListForm : Form
    {
        private readonly ISupplierRepository _supplierRepository;
        public SupplierListForm(ISupplierRepository supplierRepository)
        {
            InitializeComponent();
            _supplierRepository = supplierRepository;
        }

        private void SupplierListForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }
        private void RefreshGrid()
        {
            dgvSuppliers.DataSource = null;
            dgvSuppliers.DataSource = _supplierRepository.GetAll().ToList();
            if (dgvSuppliers.Columns["Id"] != null)
                dgvSuppliers.Columns["Id"].Visible = false;
            if (dgvSuppliers.Columns["Name"] != null)
                dgvSuppliers.Columns["Name"].HeaderText = "Название поставщика";
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            using (var editForm = new SupplierEditForm(_supplierRepository))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if(dgvSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите поставщика для редактирования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedSupplier = dgvSuppliers.SelectedRows[0].DataBoundItem as Supplier;
            if (selectedSupplier != null)
            {
                using (var editForm = new SupplierEditForm(_supplierRepository, selectedSupplier))
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
            if (dgvSuppliers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите поставщика для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedSupplier = dgvSuppliers.SelectedRows[0].DataBoundItem as Supplier;
            if (selectedSupplier != null)
            {
                var confirmResult = MessageBox.Show($"Вы уверены, что хотите удалить поставщика '{selectedSupplier.Name}'?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    _supplierRepository.Delete(selectedSupplier.Id);
                    RefreshGrid();
                }
            }
        }


    }
}
