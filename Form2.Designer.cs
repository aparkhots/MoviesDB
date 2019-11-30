namespace MoviesDB
{
    partial class Form2
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
            System.Windows.Forms.Label fIOLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label adressLabel;
            System.Windows.Forms.Label nClientLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.base_nameDataSet = new MoviesDB.base_nameDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new MoviesDB.base_nameDataSetTableAdapters.clientsTableAdapter();
            this.tableAdapterManager = new MoviesDB.base_nameDataSetTableAdapters.TableAdapterManager();
            this.clientsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.clientsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nClientNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.fIOTextBox = new System.Windows.Forms.TextBox();
            fIOLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            adressLabel = new System.Windows.Forms.Label();
            nClientLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.base_nameDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingNavigator)).BeginInit();
            this.clientsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nClientNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // fIOLabel
            // 
            fIOLabel.AutoSize = true;
            fIOLabel.Location = new System.Drawing.Point(216, 119);
            fIOLabel.Name = "fIOLabel";
            fIOLabel.Size = new System.Drawing.Size(37, 13);
            fIOLabel.TabIndex = 2;
            fIOLabel.Text = "ФИО:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(202, 157);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(55, 13);
            phoneLabel.TabIndex = 4;
            phoneLabel.Text = "Телефон:";
            // 
            // adressLabel
            // 
            adressLabel.AutoSize = true;
            adressLabel.Location = new System.Drawing.Point(216, 197);
            adressLabel.Name = "adressLabel";
            adressLabel.Size = new System.Drawing.Size(41, 13);
            adressLabel.TabIndex = 6;
            adressLabel.Text = "Адрес:";
            // 
            // nClientLabel
            // 
            nClientLabel.AutoSize = true;
            nClientLabel.Location = new System.Drawing.Point(169, 88);
            nClientLabel.Name = "nClientLabel";
            nClientLabel.Size = new System.Drawing.Size(88, 13);
            nClientLabel.TabIndex = 21;
            nClientLabel.Text = "Номер клиента:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(259, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Таблица \"Клиенты\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // base_nameDataSet
            // 
            this.base_nameDataSet.DataSetName = "base_nameDataSet";
            this.base_nameDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.base_nameDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.moviesTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MoviesDB.base_nameDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientsBindingNavigator
            // 
            this.clientsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientsBindingNavigator.BindingSource = this.clientsBindingSource;
            this.clientsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.clientsBindingNavigatorSaveItem});
            this.clientsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientsBindingNavigator.Name = "clientsBindingNavigator";
            this.clientsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.clientsBindingNavigator.TabIndex = 1;
            this.clientsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // clientsBindingNavigatorSaveItem
            // 
            this.clientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientsBindingNavigatorSaveItem.Image")));
            this.clientsBindingNavigatorSaveItem.Name = "clientsBindingNavigatorSaveItem";
            this.clientsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clientsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.clientsBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientsBindingNavigatorSaveItem_Click);
            // 
            // adressTextBox
            // 
            this.adressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "adress", true));
            this.adressTextBox.Location = new System.Drawing.Point(263, 194);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(209, 20);
            this.adressTextBox.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(313, 332);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 23);
            this.button7.TabIndex = 21;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(421, 294);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(313, 294);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(223, 294);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(421, 256);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Phone", true));
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(263, 157);
            this.phoneMaskedTextBox.Mask = "000-0000";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(209, 20);
            this.phoneMaskedTextBox.TabIndex = 23;
            // 
            // nClientNumericUpDown
            // 
            this.nClientNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientsBindingSource, "nClient", true));
            this.nClientNumericUpDown.Location = new System.Drawing.Point(263, 86);
            this.nClientNumericUpDown.Name = "nClientNumericUpDown";
            this.nClientNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.nClientNumericUpDown.TabIndex = 24;
            // 
            // fIOTextBox
            // 
            this.fIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "FIO", true));
            this.fIOTextBox.Location = new System.Drawing.Point(263, 116);
            this.fIOTextBox.Name = "fIOTextBox";
            this.fIOTextBox.Size = new System.Drawing.Size(209, 20);
            this.fIOTextBox.TabIndex = 26;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fIOTextBox);
            this.Controls.Add(this.nClientNumericUpDown);
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(nClientLabel);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(adressLabel);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(fIOLabel);
            this.Controls.Add(this.clientsBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Таблица \"Клиенты\"";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.base_nameDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingNavigator)).EndInit();
            this.clientsBindingNavigator.ResumeLayout(false);
            this.clientsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nClientNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private base_nameDataSet base_nameDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private base_nameDataSetTableAdapters.clientsTableAdapter clientsTableAdapter;
        private base_nameDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton clientsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.NumericUpDown nClientNumericUpDown;
        private System.Windows.Forms.TextBox fIOTextBox;
    }
}