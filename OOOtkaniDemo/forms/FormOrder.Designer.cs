namespace OOOtkaniDemo.forms
{
    partial class FormOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.priceLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pickuppointsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pickUpPointDataSet = new OOOtkaniDemo.pickUpPointDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.pick_up_pointsTableAdapter = new OOOtkaniDemo.pickUpPointDataSetTableAdapters.pick_up_pointsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickuppointsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickUpPointDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Заказ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.orderDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.orderDataGridView.Location = new System.Drawing.Point(12, 117);
            this.orderDataGridView.MultiSelect = false;
            this.orderDataGridView.Name = "orderDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.orderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderDataGridView.Size = new System.Drawing.Size(776, 338);
            this.orderDataGridView.TabIndex = 4;
            this.orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.goodsDataGridView_CellContentClick);
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 82);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(35, 13);
            this.priceLabel.TabIndex = 6;
            this.priceLabel.Text = "label2";
            // 
            // discountLabel
            // 
            this.discountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(174, 82);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(35, 13);
            this.discountLabel.TabIndex = 7;
            this.discountLabel.Text = "label2";
            // 
            // orderButton
            // 
            this.orderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.orderButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.orderButton.Location = new System.Drawing.Point(542, 461);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(246, 45);
            this.orderButton.TabIndex = 8;
            this.orderButton.Text = "Заказать";
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DataSource = this.pickuppointsBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(667, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "id";
            // 
            // pickuppointsBindingSource
            // 
            this.pickuppointsBindingSource.DataMember = "pick_up_points";
            this.pickuppointsBindingSource.DataSource = this.pickUpPointDataSet;
            // 
            // pickUpPointDataSet
            // 
            this.pickUpPointDataSet.DataSetName = "pickUpPointDataSet";
            this.pickUpPointDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Пункт выдачи";
            // 
            // pick_up_pointsTableAdapter
            // 
            this.pick_up_pointsTableAdapter.ClearBeforeFill = true;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderDataGridView);
            this.Name = "FormOrder";
            this.Text = "Форма заказа";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickuppointsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickUpPointDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private pickUpPointDataSet pickUpPointDataSet;
        private System.Windows.Forms.BindingSource pickuppointsBindingSource;
        private pickUpPointDataSetTableAdapters.pick_up_pointsTableAdapter pick_up_pointsTableAdapter;
    }
}