namespace OOOtkaniDemo.forms
{
    partial class FormUpdateGood
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
            this.addButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.manufactuterComboBox = new System.Windows.Forms.ComboBox();
            this.manufacturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerDataSet = new OOOtkaniDemo.manufacturerDataSet();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.manufacturersTableAdapter = new OOOtkaniDemo.manufacturerDataSetTableAdapters.manufacturersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(74, 352);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(223, 74);
            this.addButton.TabIndex = 30;
            this.addButton.Text = "Сохранить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(56, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Количество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(78, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Скидка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(89, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(36, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Производитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(65, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(65, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Название";
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(134, 281);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(121, 20);
            this.countTextBox.TabIndex = 23;
            // 
            // discountTextBox
            // 
            this.discountTextBox.Location = new System.Drawing.Point(134, 244);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(121, 20);
            this.discountTextBox.TabIndex = 22;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(134, 204);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(121, 20);
            this.priceTextBox.TabIndex = 21;
            // 
            // manufactuterComboBox
            // 
            this.manufactuterComboBox.DataSource = this.manufacturersBindingSource;
            this.manufactuterComboBox.DisplayMember = "name";
            this.manufactuterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufactuterComboBox.FormattingEnabled = true;
            this.manufactuterComboBox.Location = new System.Drawing.Point(134, 165);
            this.manufactuterComboBox.Name = "manufactuterComboBox";
            this.manufactuterComboBox.Size = new System.Drawing.Size(121, 21);
            this.manufactuterComboBox.TabIndex = 20;
            this.manufactuterComboBox.ValueMember = "id";
            // 
            // manufacturersBindingSource
            // 
            this.manufacturersBindingSource.DataMember = "manufacturers";
            this.manufacturersBindingSource.DataSource = this.manufacturerDataSetBindingSource;
            // 
            // manufacturerDataSetBindingSource
            // 
            this.manufacturerDataSetBindingSource.DataSource = this.manufacturerDataSet;
            this.manufacturerDataSetBindingSource.Position = 0;
            // 
            // manufacturerDataSet
            // 
            this.manufacturerDataSet.DataSetName = "manufacturerDataSet";
            this.manufacturerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(134, 128);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(121, 20);
            this.descriptionTextBox.TabIndex = 19;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(134, 87);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameTextBox.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 39);
            this.label1.TabIndex = 17;
            this.label1.Text = "Обновление товара";
            // 
            // manufacturersTableAdapter
            // 
            this.manufacturersTableAdapter.ClearBeforeFill = true;
            // 
            // FormUpdateGood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.manufactuterComboBox);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(377, 489);
            this.MinimumSize = new System.Drawing.Size(377, 489);
            this.Name = "FormUpdateGood";
            this.Text = "Обновление товара";
            this.Load += new System.EventHandler(this.FormUpdateGood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manufacturersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox manufactuterComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource manufacturerDataSetBindingSource;
        private manufacturerDataSet manufacturerDataSet;
        private System.Windows.Forms.BindingSource manufacturersBindingSource;
        private manufacturerDataSetTableAdapters.manufacturersTableAdapter manufacturersTableAdapter;
    }
}