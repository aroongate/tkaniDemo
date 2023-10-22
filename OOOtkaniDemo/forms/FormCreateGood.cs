using OOOtkaniDemo.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOOtkaniDemo.forms
{
    public partial class FormCreateGood : Form
    {
        public FormCreateGood()
        {
            InitializeComponent();
        }

        private void FormCreateGood_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manufacturerDataSet.manufacturers". При необходимости она может быть перемещена или удалена.
            this.manufacturersTableAdapter.Fill(this.manufacturerDataSet.manufacturers);

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using(modelDB model = new modelDB())
            {
                goods goods = new goods();
                goods.name = nameTextBox.Text;
                goods.description = descriptionTextBox.Text;
                goods.price = Convert.ToDouble(priceTextBox.Text);
                goods.manufacturer_id = (int)manufactuterComboBox.SelectedValue;
                goods.discount = Convert.ToInt32(discountTextBox.Text);
                goods.count = Convert.ToInt32(countTextBox.Text);
                model.goods.Add(goods);
                model.SaveChanges();
                MessageBox.Show("Успешно создано");
                Hide();
            }
        }
    }
}
