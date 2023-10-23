using Microsoft.Office.Interop.Word;
using OOOtkaniDemo.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOOtkaniDemo.forms
{
    public partial class FormOrder : Form
    {
        double price;
        double discount;
        private List<goodsViev> goodsVievs = new List<goodsViev>();
        public FormOrder(List<goodsViev> goodsVievs)
        {
            InitializeComponent();
            
            orderDataGridView.DataSource = goodsVievs;
            orderDataGridView.Columns["id"].HeaderText = "Код";
            orderDataGridView.Columns["id"].ReadOnly = true;
            orderDataGridView.Columns["name"].HeaderText = "Название";
            orderDataGridView.Columns["name"].ReadOnly = true;
            orderDataGridView.Columns["description"].HeaderText = "Описание";
            orderDataGridView.Columns["description"].ReadOnly = true;
            orderDataGridView.Columns["Expr1"].HeaderText = "Производитель";
            orderDataGridView.Columns["Expr1"].ReadOnly = true;
            orderDataGridView.Columns["price"].HeaderText = "Цена";
            orderDataGridView.Columns["price"].ReadOnly = true;
            orderDataGridView.Columns["discount"].HeaderText = "Скидка";
            orderDataGridView.Columns["discount"].ReadOnly = true;
            orderDataGridView.Columns["image"].HeaderText = "Изображение";
            orderDataGridView.Columns["image"].ReadOnly = true;
            podschetPrice(goodsVievs);
        }

        private void goodsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pickUpPointDataSet.pick_up_points". При необходимости она может быть перемещена или удалена.
            this.pick_up_pointsTableAdapter.Fill(this.pickUpPointDataSet.pick_up_points);

        }

        private void podschetPrice(List<goodsViev> goods)
        {
            price = 0;
            discount = 0;
            foreach (goodsViev good in goods)
            {
                price += good.price;
                discount += (double)good.discount;
            }

            priceLabel.Text = "Сумма заказа: " + price.ToString() + " руб.";
            discountLabel.Text = "Сумма скидки: " + discount.ToString() + " руб.";
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            try
            {
                var app = new Microsoft.Office.Interop.Word.Application();
                var doc = app.Documents.Add();
                var title = doc.Paragraphs.Add();
                title.Range.Text = "Талон заказа";
                title.Range.Font.Size = 18;
                title.Range.Font.Bold = 1;
                title.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                title.Range.InsertParagraphAfter();

                Random random = new Random();
                using (modelDB model = new modelDB())
                {
                    int nextId = model.orders.Max(o => o.id) + 1;

                    orders orders = new orders();
                    orders.id = nextId;
                    var par = doc.Paragraphs.Add();
                    par.Range.Text = "Дата заказа: " + DateTime.Now;
                    par.Range.InsertParagraphAfter();
                    par.Range.Text = "Номер заказа:" + nextId;
                    par.Range.InsertParagraphAfter();
                    var parItems = doc.Paragraphs.Add();
                    orders.price = price;
                    orders.price_discount = discount;
                    orders.users = null;
                    orders.code = random.Next(100, 1000);
                    orders.statuses = model.statuses.Find(1);
                    orders.pick_up_points = model.pick_up_points.Where(i => i.name == comboBox1.Text).FirstOrDefault();
                    orders.date = DateTime.Now;
                    model.orders.Add(orders);
                    model.SaveChanges();

                    Paragraph orderItems = doc.Paragraphs.Add();
                    orderItems.Range.Text = "Состав заказа:";

                    foreach (DataGridViewRow row in orderDataGridView.Rows)
                    {
                        if (row.Cells["id"].Value != null)
                        {
                            int goodId = (int)row.Cells["id"].Value;

                            good_order goodOrder = new good_order();
                            goodOrder.order_id = orders.id;
                            goodOrder.good_id = goodId;
                            var good = model.goods.Find(goodId);

                            Paragraph itemRow = doc.Paragraphs.Add();
                            itemRow.Range.Text = $"{good.id}. {good.name} Цена: {good.price} руб. Скидка: {good.discount} руб.";
                            itemRow.Range.Italic = 0;
                            itemRow.Range.Bold = 0;
                            itemRow.Range.InsertParagraphAfter();

                            model.good_order.Add(goodOrder);
                        }
                    }

                    Paragraph summaPar = doc.Paragraphs.Add();
                    summaPar.Range.Text = $"Сумма заказа: {orders.price} руб. ";
                    summaPar.Range.Italic = 0;
                    summaPar.Range.Bold = 0;
                    summaPar.Range.InsertParagraphAfter();

                    Paragraph salePar = doc.Paragraphs.Add();
                    salePar.Range.Text = $"Сумма скидки: {orders.price_discount} руб.";
                    salePar.Range.Italic = 0;
                    salePar.Range.Bold = 0;
                    salePar.Range.InsertParagraphAfter();

                    Paragraph pickupPoint = doc.Paragraphs.Add();
                    pickupPoint.Range.Text = "Пункт выдачи: " + model.pick_up_points.Where(i => i.name == comboBox1.Text).FirstOrDefault().name;
                    pickupPoint.Range.Italic = 0;
                    pickupPoint.Range.Bold = 0;
                    pickupPoint.Range.InsertParagraphAfter();

                    Paragraph pickupCode = doc.Paragraphs.Add();
                    pickupCode.Range.Text = "Код получения: " + random.Next(100, 1000);
                    pickupCode.Range.Bold = 1;
                    pickupCode.Range.Italic = 1;
                    pickupCode.Range.InsertParagraphAfter();

                    Paragraph datePar = doc.Paragraphs.Add();
                    datePar.Range.Text = "Срок доставки: 3 дня";
                    datePar.Range.Italic = 0;
                    datePar.Range.Bold = 0;
                    datePar.Range.InsertParagraphAfter();

                    object path = "D:\\ttt.pdf";

                    doc.SaveAs(path, WdSaveFormat.wdFormatPDF);

                    Document docMem = app.Documents.Open(ref path);

                    
                    app.Visible = true;
                    model.SaveChanges();

                    MessageBox.Show("Успешно заказано");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Нет соединения с базой данных");
            }
        }
    }
}
