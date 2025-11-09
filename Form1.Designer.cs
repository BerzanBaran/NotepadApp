namespace myAgenda
{
    partial class lblMyAgenda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            calendarMain = new MonthCalendar();
            ListBoxEvents = new ListBox();
            label1 = new Label();
            btnTodayClick = new Button();
            btnExitClick = new Button();
            btnSignClick = new Button();
            btnDelClick = new Button();
            btnActivityAdd = new Button();
            txt_etkinlik = new TextBox();
            SuspendLayout();
            // 
            // calendarMain
            // 
            calendarMain.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            calendarMain.Location = new Point(340, 87);
            calendarMain.Name = "calendarMain";
            calendarMain.TabIndex = 0;
            calendarMain.DateChanged += calendarMain_DateChanged;
            // 
            // ListBoxEvents
            // 
            ListBoxEvents.FormattingEnabled = true;
            ListBoxEvents.Location = new Point(2, 10);
            ListBoxEvents.Name = "ListBoxEvents";
            ListBoxEvents.Size = new Size(255, 439);
            ListBoxEvents.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Coral;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(389, 9);
            label1.Name = "label1";
            label1.Size = new Size(98, 30);
            label1.TabIndex = 2;
            label1.Text = "Ajandam";
            label1.Click += label1_Click;
            // 
            // btnTodayClick
            // 
            btnTodayClick.BackColor = Color.Coral;
            btnTodayClick.ForeColor = Color.Black;
            btnTodayClick.Location = new Point(658, 65);
            btnTodayClick.Name = "btnTodayClick";
            btnTodayClick.Size = new Size(114, 47);
            btnTodayClick.TabIndex = 3;
            btnTodayClick.Text = "Bugün";
            btnTodayClick.UseVisualStyleBackColor = false;
            btnTodayClick.Click += btnTodayClick_Click_1;
            // 
            // btnExitClick
            // 
            btnExitClick.BackColor = Color.Coral;
            btnExitClick.Location = new Point(658, 390);
            btnExitClick.Name = "btnExitClick";
            btnExitClick.Size = new Size(114, 48);
            btnExitClick.TabIndex = 4;
            btnExitClick.Text = "Çıkış";
            btnExitClick.UseVisualStyleBackColor = false;
            btnExitClick.Click += btnExitClick_Click_1;
            // 
            // btnSignClick
            // 
            btnSignClick.BackColor = Color.Coral;
            btnSignClick.Location = new Point(658, 299);
            btnSignClick.Name = "btnSignClick";
            btnSignClick.Size = new Size(114, 44);
            btnSignClick.TabIndex = 5;
            btnSignClick.Text = "İşaretle";
            btnSignClick.UseVisualStyleBackColor = false;
            // 
            // btnDelClick
            // 
            btnDelClick.BackColor = Color.Coral;
            btnDelClick.Location = new Point(658, 222);
            btnDelClick.Name = "btnDelClick";
            btnDelClick.Size = new Size(114, 44);
            btnDelClick.TabIndex = 6;
            btnDelClick.Text = "Sil";
            btnDelClick.UseVisualStyleBackColor = false;
            // 
            // btnActivityAdd
            // 
            btnActivityAdd.BackColor = Color.Coral;
            btnActivityAdd.Location = new Point(658, 142);
            btnActivityAdd.Name = "btnActivityAdd";
            btnActivityAdd.Size = new Size(114, 46);
            btnActivityAdd.TabIndex = 7;
            btnActivityAdd.Text = "Etkinlik Ekle";
            btnActivityAdd.UseVisualStyleBackColor = false;
            btnActivityAdd.Click += btnActivityAdd_Click_1;
            // 
            // txt_etkinlik
            // 
            txt_etkinlik.Location = new Point(294, 285);
            txt_etkinlik.Multiline = true;
            txt_etkinlik.Name = "txt_etkinlik";
            txt_etkinlik.Size = new Size(328, 135);
            txt_etkinlik.TabIndex = 8;
            // 
            // lblMyAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_etkinlik);
            Controls.Add(btnActivityAdd);
            Controls.Add(btnDelClick);
            Controls.Add(btnSignClick);
            Controls.Add(btnExitClick);
            Controls.Add(btnTodayClick);
            Controls.Add(label1);
            Controls.Add(ListBoxEvents);
            Controls.Add(calendarMain);
            Name = "lblMyAgenda";
            Text = "Form1";
            FormClosing += lblMyAgenda_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar calendarMain;
        private ListBox ListBoxEvents;
        private Label label1;
        private Button btnTodayClick;
        private Button btnExitClick;
        private Button btnSignClick;
        private Button btnDelClick;
        private Button btnActivityAdd;
        private TextBox txt_etkinlik;
    }
}
