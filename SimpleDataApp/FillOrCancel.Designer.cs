namespace SimpleDataApp
{
    partial class FillOrCancel
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
            label1 = new Label();
            txtOrderID = new TextBox();
            btnFindByOrderID = new Button();
            label2 = new Label();
            dtpFillDate = new DateTimePicker();
            dgvCustomerOrders = new DataGridView();
            btnCancelOrder = new Button();
            btnFillOrder = new Button();
            btnFinishUpdates = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrders).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 41);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 0;
            label1.Text = "Идентификатор заказа:";
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(186, 38);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(186, 23);
            txtOrderID.TabIndex = 1;
            // 
            // btnFindByOrderID
            // 
            btnFindByOrderID.Location = new Point(416, 38);
            btnFindByOrderID.Name = "btnFindByOrderID";
            btnFindByOrderID.Size = new Size(107, 23);
            btnFindByOrderID.TabIndex = 2;
            btnFindByOrderID.Text = "Найти заказ";
            btnFindByOrderID.UseVisualStyleBackColor = true;
            btnFindByOrderID.Click += btnFindByOrderID_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 119);
            label2.Name = "label2";
            label2.Size = new Size(271, 15);
            label2.TabIndex = 3;
            label2.Text = "При заполнении заказа укажите дату заполения";
            // 
            // dtpFillDate
            // 
            dtpFillDate.Format = DateTimePickerFormat.Short;
            dtpFillDate.Location = new Point(323, 113);
            dtpFillDate.Name = "dtpFillDate";
            dtpFillDate.Size = new Size(200, 23);
            dtpFillDate.TabIndex = 4;
            // 
            // dgvCustomerOrders
            // 
            dgvCustomerOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerOrders.Location = new Point(46, 157);
            dgvCustomerOrders.Name = "dgvCustomerOrders";
            dgvCustomerOrders.ReadOnly = true;
            dgvCustomerOrders.RowHeadersVisible = false;
            dgvCustomerOrders.RowTemplate.Height = 25;
            dgvCustomerOrders.Size = new Size(609, 150);
            dgvCustomerOrders.TabIndex = 5;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Location = new Point(46, 330);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(124, 23);
            btnCancelOrder.TabIndex = 6;
            btnCancelOrder.Text = "Отменить заказ";
            btnCancelOrder.UseVisualStyleBackColor = true;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // btnFillOrder
            // 
            btnFillOrder.Location = new Point(214, 330);
            btnFillOrder.Name = "btnFillOrder";
            btnFillOrder.Size = new Size(127, 23);
            btnFillOrder.TabIndex = 7;
            btnFillOrder.Text = "Заполнить заказ";
            btnFillOrder.UseVisualStyleBackColor = true;
            btnFillOrder.Click += btnFillOrder_Click;
            // 
            // btnFinishUpdates
            // 
            btnFinishUpdates.Location = new Point(580, 330);
            btnFinishUpdates.Name = "btnFinishUpdates";
            btnFinishUpdates.Size = new Size(75, 23);
            btnFinishUpdates.TabIndex = 8;
            btnFinishUpdates.Text = "Готово";
            btnFinishUpdates.UseVisualStyleBackColor = true;
            btnFinishUpdates.Click += btnFinishUpdates_Click;
            // 
            // FillOrCancel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 378);
            Controls.Add(btnFinishUpdates);
            Controls.Add(btnFillOrder);
            Controls.Add(btnCancelOrder);
            Controls.Add(dgvCustomerOrders);
            Controls.Add(dtpFillDate);
            Controls.Add(label2);
            Controls.Add(btnFindByOrderID);
            Controls.Add(txtOrderID);
            Controls.Add(label1);
            Name = "FillOrCancel";
            Text = "FillOrCancel";
            Load += FillOrCancel_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomerOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOrderID;
        private Button btnFindByOrderID;
        private Label label2;
        private DateTimePicker dtpFillDate;
        private DataGridView dgvCustomerOrders;
        private Button btnCancelOrder;
        private Button btnFillOrder;
        private Button btnFinishUpdates;
    }
}