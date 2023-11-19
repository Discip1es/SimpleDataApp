namespace SimpleDataApp
{
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private Label label1;
        private Button btnGoToAdd;
        private Button btnGoToFillOrCancel;
        private Button btnExit;

        private void InitializeComponent()
        {
            label1 = new Label();
            btnGoToAdd = new Button();
            btnGoToFillOrCancel = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 31);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 0;
            label1.Text = "Выберите действие";
            // 
            // btnGoToAdd
            // 
            btnGoToAdd.Location = new Point(25, 72);
            btnGoToAdd.Name = "btnGoToAdd";
            btnGoToAdd.Size = new Size(184, 23);
            btnGoToAdd.TabIndex = 1;
            btnGoToAdd.Text = "Добавить учетную запись";
            btnGoToAdd.UseVisualStyleBackColor = true;
            btnGoToAdd.Click += btnGoToAdd_Click;
            // 
            // btnGoToFillOrCancel
            // 
            btnGoToFillOrCancel.Location = new Point(25, 132);
            btnGoToFillOrCancel.Name = "btnGoToFillOrCancel";
            btnGoToFillOrCancel.Size = new Size(184, 23);
            btnGoToFillOrCancel.TabIndex = 2;
            btnGoToFillOrCancel.Text = "Заполнить или отменить заказ";
            btnGoToFillOrCancel.UseVisualStyleBackColor = true;
            btnGoToFillOrCancel.Click += btnGoToFillOrCancel_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(197, 196);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 3;
            btnExit.Text = "Выйти";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Navigation
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(btnExit);
            Controls.Add(btnGoToFillOrCancel);
            Controls.Add(btnGoToAdd);
            Controls.Add(label1);
            Name = "Navigation";
            Text = "Start screen";
            ResumeLayout(false);
            PerformLayout();
        }

        /// <summary>
        /// Opens the NewCustomer form as a dialog box,
        /// which returns focus to the calling form when it is closed. 
        /// </summary>
        private void btnGoToAdd_Click(object sender, EventArgs e)
        {
            Form frm = new NewCustomer();
            frm.Show();
        }

        /// <summary>
        /// Opens the FillorCancel form as a dialog box. 
        /// </summary>
        private void btnGoToFillOrCancel_Click(object sender, EventArgs e)
        {
            Form frm = new FillOrCancel();
            frm.ShowDialog();
        }

        /// <summary>
        /// Closes the application (not just the Navigation form).
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}