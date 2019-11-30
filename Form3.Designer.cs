namespace MoviesDB
{
    partial class Form3
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
            System.Windows.Forms.Label produserLabel;
            System.Windows.Forms.Label movnameLabel;
            System.Windows.Forms.Label movyearLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.base_nameDataSet = new MoviesDB.base_nameDataSet();
            this.moviesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moviesTableAdapter = new MoviesDB.base_nameDataSetTableAdapters.moviesTableAdapter();
            this.tableAdapterManager = new MoviesDB.base_nameDataSetTableAdapters.TableAdapterManager();
            this.moviesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.moviesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.produserTextBox = new System.Windows.Forms.TextBox();
            this.movnameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.movyearComboBox = new System.Windows.Forms.ComboBox();
            produserLabel = new System.Windows.Forms.Label();
            movnameLabel = new System.Windows.Forms.Label();
            movyearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.base_nameDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingNavigator)).BeginInit();
            this.moviesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // produserLabel
            // 
            produserLabel.AutoSize = true;
            produserLabel.Location = new System.Drawing.Point(254, 169);
            produserLabel.Name = "produserLabel";
            produserLabel.Size = new System.Drawing.Size(61, 13);
            produserLabel.TabIndex = 2;
            produserLabel.Text = "Режиссер:";
            // 
            // movnameLabel
            // 
            movnameLabel.AutoSize = true;
            movnameLabel.Location = new System.Drawing.Point(212, 136);
            movnameLabel.Name = "movnameLabel";
            movnameLabel.Size = new System.Drawing.Size(103, 13);
            movnameLabel.TabIndex = 4;
            movnameLabel.Text = "Название фильма:";
            // 
            // movyearLabel
            // 
            movyearLabel.AutoSize = true;
            movyearLabel.Location = new System.Drawing.Point(278, 207);
            movyearLabel.Name = "movyearLabel";
            movyearLabel.Size = new System.Drawing.Size(28, 13);
            movyearLabel.TabIndex = 6;
            movyearLabel.Text = "Год:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(279, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Таблица \"Фильмы\" ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // base_nameDataSet
            // 
            this.base_nameDataSet.DataSetName = "base_nameDataSet";
            this.base_nameDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moviesBindingSource
            // 
            this.moviesBindingSource.DataMember = "movies";
            this.moviesBindingSource.DataSource = this.base_nameDataSet;
            // 
            // moviesTableAdapter
            // 
            this.moviesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clientsTableAdapter = null;
            this.tableAdapterManager.moviesTableAdapter = this.moviesTableAdapter;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MoviesDB.base_nameDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // moviesBindingNavigator
            // 
            this.moviesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.moviesBindingNavigator.BindingSource = this.moviesBindingSource;
            this.moviesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.moviesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.moviesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.moviesBindingNavigatorSaveItem});
            this.moviesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.moviesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.moviesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.moviesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.moviesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.moviesBindingNavigator.Name = "moviesBindingNavigator";
            this.moviesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.moviesBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.moviesBindingNavigator.TabIndex = 2;
            this.moviesBindingNavigator.Text = "bindingNavigator1";
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
            // moviesBindingNavigatorSaveItem
            // 
            this.moviesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moviesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("moviesBindingNavigatorSaveItem.Image")));
            this.moviesBindingNavigatorSaveItem.Name = "moviesBindingNavigatorSaveItem";
            this.moviesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.moviesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.moviesBindingNavigatorSaveItem.Click += new System.EventHandler(this.moviesBindingNavigatorSaveItem_Click);
            // 
            // produserTextBox
            // 
            this.produserTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource, "produser", true));
            this.produserTextBox.Location = new System.Drawing.Point(321, 169);
            this.produserTextBox.Name = "produserTextBox";
            this.produserTextBox.Size = new System.Drawing.Size(100, 20);
            this.produserTextBox.TabIndex = 3;
            // 
            // movnameTextBox
            // 
            this.movnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource, "movname", true));
            this.movnameTextBox.Location = new System.Drawing.Point(321, 133);
            this.movnameTextBox.Name = "movnameTextBox";
            this.movnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.movnameTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Первая";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Предыдущая";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(429, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(231, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Последняя";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(321, 313);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Следующая";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(429, 313);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(321, 351);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 23);
            this.button7.TabIndex = 14;
            this.button7.Text = "Сохранить";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // movyearComboBox
            // 
            this.movyearComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.moviesBindingSource, "movyear", true));
            this.movyearComboBox.FormattingEnabled = true;
            this.movyearComboBox.Items.AddRange(new object[] {
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004"});
            this.movyearComboBox.Location = new System.Drawing.Point(322, 204);
            this.movyearComboBox.Name = "movyearComboBox";
            this.movyearComboBox.Size = new System.Drawing.Size(121, 21);
            this.movyearComboBox.TabIndex = 16;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.movyearComboBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(movyearLabel);
            this.Controls.Add(movnameLabel);
            this.Controls.Add(this.movnameTextBox);
            this.Controls.Add(produserLabel);
            this.Controls.Add(this.produserTextBox);
            this.Controls.Add(this.moviesBindingNavigator);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Таблица \"Фильмы\" ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.base_nameDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moviesBindingNavigator)).EndInit();
            this.moviesBindingNavigator.ResumeLayout(false);
            this.moviesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private base_nameDataSet base_nameDataSet;
        private System.Windows.Forms.BindingSource moviesBindingSource;
        private base_nameDataSetTableAdapters.moviesTableAdapter moviesTableAdapter;
        private base_nameDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator moviesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton moviesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox produserTextBox;
        private System.Windows.Forms.TextBox movnameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox movyearComboBox;
    }
}