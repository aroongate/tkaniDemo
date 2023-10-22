using OOOtkaniDemo.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOOtkaniDemo.forms
{
    public partial class FormUpdateGood : Form
    {
        private int id;
        public FormUpdateGood(int id)
        {
            InitializeComponent();
            this.id = id;
            using(modelDB  model = new modelDB())
            {
                goods good = model.goods.Find(id);
                nameTextBox.Text = good.name;
                descriptionTextBox.Text = good.description;
                priceTextBox.Text = Convert.ToString(good.price);
                countTextBox.Text = Convert.ToString(good.count);
                discountTextBox.Text = Convert.ToString(good.discount);
                manufactuterComboBox.Text = good.manufacturers.name;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (modelDB model = new modelDB())
            {
                goods good = model.goods.Find(id);
                good.name = nameTextBox.Text;
                good.description = descriptionTextBox.Text;
                good.price = Convert.ToDouble(priceTextBox.Text);
                good.count = Convert.ToInt16(countTextBox.Text);
                good.discount = Convert.ToInt16(discountTextBox.Text);
                good.manufacturer_id = (int)manufactuterComboBox.SelectedValue;
                model.SaveChanges();
                MessageBox.Show("Изменения сохранены");
                Hide();
            }
        }

        private void FormUpdateGood_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "manufacturerDataSet.manufacturers". При необходимости она может быть перемещена или удалена.
            this.manufacturersTableAdapter.Fill(this.manufacturerDataSet.manufacturers);

        }
    }
}
