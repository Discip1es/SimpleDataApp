namespace SimpleDataApp
{
    partial class NewCustomer
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
            groupBox1 = new GroupBox();
            txtCustomerID = new TextBox();
            txtCustomerName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dtpOrderDate = new DateTimePicker();
            numOrderAmount = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            btnCreateAccount = new Button();
            btnPlaceOrder = new Button();
            btnAddFinish = new Button();
            btnAddAnotherAccount = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numOrderAmount).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCustomerID);
            groupBox1.Controls.Add(txtCustomerName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(40, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Добавление учетной записи";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(173, 60);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.ReadOnly = true;
            txtCustomerID.Size = new Size(100, 23);
            txtCustomerID.TabIndex = 3;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(108, 27);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(165, 23);
            txtCustomerName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 63);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 1;
            label2.Text = "Идентификатор клиента";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 30);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Имя заказчика:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtpOrderDate);
            groupBox2.Controls.Add(numOrderAmount);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(40, 238);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(288, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Создание заказа";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Format = DateTimePickerFormat.Short;
            dtpOrderDate.Location = new Point(109, 57);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(164, 23);
            dtpOrderDate.TabIndex = 3;
            // 
            // numOrderAmount
            // 
            numOrderAmount.Location = new Point(108, 28);
            numOrderAmount.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numOrderAmount.Name = "numOrderAmount";
            numOrderAmount.Size = new Size(165, 23);
            numOrderAmount.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 63);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 1;
            label4.Text = "Дата заказа:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 30);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 0;
            label3.Text = "Сумма заказа:";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(367, 106);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(135, 40);
            btnCreateAccount.TabIndex = 2;
            btnCreateAccount.Text = "Создать учетную запись";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnPlaceOrder
            // 
            btnPlaceOrder.Location = new Point(367, 295);
            btnPlaceOrder.Name = "btnPlaceOrder";
            btnPlaceOrder.Size = new Size(135, 40);
            btnPlaceOrder.TabIndex = 3;
            btnPlaceOrder.Text = "Разместить заказ";
            btnPlaceOrder.UseVisualStyleBackColor = true;
            btnPlaceOrder.Click += btnPlaceOrder_Click;
            // 
            // btnAddFinish
            // 
            btnAddFinish.Location = new Point(40, 382);
            btnAddFinish.Name = "btnAddFinish";
            btnAddFinish.Size = new Size(75, 23);
            btnAddFinish.TabIndex = 4;
            btnAddFinish.Text = "Готово";
            btnAddFinish.UseVisualStyleBackColor = true;
            btnAddFinish.Click += btnAddFinish_Click;
            // 
            // btnAddAnotherAccount
            // 
            btnAddAnotherAccount.Location = new Point(273, 382);
            btnAddAnotherAccount.Name = "btnAddAnotherAccount";
            btnAddAnotherAccount.Size = new Size(229, 23);
            btnAddAnotherAccount.TabIndex = 5;
            btnAddAnotherAccount.Text = "Добавить другую учетную запись";
            btnAddAnotherAccount.UseVisualStyleBackColor = true;
            btnAddAnotherAccount.Click += btnAddAnotherAccount_Click;
            // 
            // NewCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 450);
            Controls.Add(btnAddAnotherAccount);
            Controls.Add(btnAddFinish);
            Controls.Add(btnPlaceOrder);
            Controls.Add(btnCreateAccount);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "NewCustomer";
            Text = "NewCustomer";
            Load += NewCustomer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numOrderAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtCustomerID;
        private TextBox txtCustomerName;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpOrderDate;
        private NumericUpDown numOrderAmount;
        private Button btnCreateAccount;
        private Button btnPlaceOrder;
        private Button btnAddFinish;
        private Button btnAddAnotherAccount;
    }
}