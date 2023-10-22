using OOOtkaniDemo.database;
using OOOtkaniDemo.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOOtkaniDemo
{
    public partial class FormGoods : Form
    {
        private List<goodsViev> goodsView = new List<goodsViev>(); 
        public FormGoods()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricsDataSet.goodsViev". При необходимости она может быть перемещена или удалена.
            this.goodsVievTableAdapter.Fill(this.fabricsDataSet.goodsViev);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "fabricsDataSet.goodsViev". При необходимости она может быть перемещена или удалена.
            this.goodsVievTableAdapter.Fill(this.fabricsDataSet.goodsViev);

        }

        private void ContextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DataGridView dataGridView = goodsDataGridView;
            switch (e.ClickedItem.Text)
                {
                    case "Добавить к заказу":
                        if (dataGridView != null && dataGridView.SelectedRows.Count > 0)
                        {
                            int selectedRow = dataGridView.SelectedRows[0].Index;
                            int cellValue = Convert.ToInt32(dataGridView["dataGridViewTextBoxColumn1", selectedRow].Value);
                            using (modelDB model = new modelDB())
                            {
                                goodsViev good = model.goodsViev.Where(i => i.id == cellValue).FirstOrDefault();
                                goodsView.Add(good);
                                if (goodsView.Count > 0)
                                {
                                    seeOrderButton.Visible = true;
                                }
                            }
                        }
                        break;
                case "Создать товар":
                    FormCreateGood formCreateGood = new FormCreateGood();
                    formCreateGood.Show();
                    break;
                case "Редактировать товар":
                    if (dataGridView != null && dataGridView.SelectedRows.Count > 0)
                    {
                        int selectedRow = dataGridView.SelectedRows[0].Index;
                        int cellValue = Convert.ToInt32(dataGridView["dataGridViewTextBoxColumn1", selectedRow].Value);
                        FormUpdateGood formUpdateGood = new FormUpdateGood(cellValue);
                        formUpdateGood.Show();
                    }
                    break;
                case "Удалить товар":
                    if (dataGridView != null && dataGridView.SelectedRows.Count > 0)
                    {
                        int selectedRow = dataGridView.SelectedRows[0].Index;
                        int cellValue = Convert.ToInt32(dataGridView["dataGridViewTextBoxColumn1", selectedRow].Value);
                        using (modelDB model = new modelDB())
                        {
                            model.goods.Remove(model.goods.Find(cellValue));
                            model.SaveChanges();
                            goodsDataGridView.DataSource = model.goodsViev.ToList();
                        }
                    }
                    break;
            }
        }

        private void goodsDataGridView_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ContextMenuStrip contextMenuStrip = new ContextMenuStrip();
                contextMenuStrip.Items.Add("Добавить к заказу");
                contextMenuStrip.Items.Add("Создать товар");
                contextMenuStrip.Items.Add("Редактировать товар");
                contextMenuStrip.Items.Add("Удалить товар");
                contextMenuStrip.ItemClicked += ContextMenuStrip_ItemClicked;
                e.ContextMenuStrip = contextMenuStrip;
            }
        }

        private void seeOrderButton_Click(object sender, EventArgs e)
        {

            FormOrder formOrder = new FormOrder(goodsView);
            formOrder.ShowDialog();
        }

        private void goodsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormGoods_Activated(object sender, EventArgs e)
        {
            using(modelDB model = new modelDB())
            {
                goodsDataGridView.DataSource = model.goodsViev.ToList();
            }
           
        }
    }
}
