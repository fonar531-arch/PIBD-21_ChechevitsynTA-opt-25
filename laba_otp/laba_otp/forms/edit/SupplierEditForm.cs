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
    public partial class SupplierEditForm : Form
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly Supplier _existingSupplier;

        public SupplierEditForm(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
            InitializeComponent();
            this.Text = "Добавление поставщика";

        }
        public SupplierEditForm(ISupplierRepository supplierRepository, Supplier supplier) : this(supplierRepository)
        {
            _existingSupplier = supplier;
            txtName.Text = _existingSupplier.Name;
            this.Text = "Редактирование поставщика";

        }
        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (_existingSupplier == null)
                {
                    var newSupplier = Supplier.Create(txtName.Text);
                    _supplierRepository.Add(newSupplier);
                }
                else
                {
                    _existingSupplier.UpdateName(txtName.Text);
                    _supplierRepository.Update(_existingSupplier);
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
