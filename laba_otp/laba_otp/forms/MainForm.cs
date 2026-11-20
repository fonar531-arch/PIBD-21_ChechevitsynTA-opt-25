using otp_lab_25;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace otp_lab_25
{
    public partial class MainForm : Form
    {
        private readonly IUnityContainer _container;

        public MainForm(IUnityContainer container)
        {
            _container = container;
            InitializeComponent();
        }

        private void fdsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _container.Resolve<SupplierListForm>().ShowDialog();
        }

        private void fdsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _container.Resolve<CategoryListForm>().ShowDialog();
        }

        private void fdsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _container.Resolve<ProductListForm>().ShowDialog();
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            _container.Resolve<ProductBatchForm>().ShowDialog();
        }

        private void продажиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _container.Resolve<SaleForm>().ShowDialog();
        }

        private void заявкиНаПополнениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _container.Resolve<ReplenishmentRequestForm>().ShowDialog();
        }
    }
}
