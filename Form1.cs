using System.Diagnostics.Eventing.Reader;

namespace myAgenda
{
    public partial class lblMyAgenda : Form
    {
        public lblMyAgenda()
        {
            InitializeComponent();
        }
        Dictionary<DateTime, List<string>> etkinlikler = new Dictionary<DateTime, List<string>>();
        private DateTime secilenTarih;

        private void Form1_Load(object sender, EventArgs e)
        {

            EtkinlikleriYukle();
            EtkinliklerGoster(calendarMain.SelectionStart);
            EtkinklikleriKaydet();

        }
        //Buradan itibaren silinecek
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTodayClick_Click(object sender, EventArgs e)
        {
            // Today button click handler
            calendarMain.SetDate(DateTime.Today);
        }

        private void btnActivityAdd_Click(object sender, EventArgs e)
        {
            // Add activity button click handler
            if (!string.IsNullOrEmpty(txt_etkinlik.Text))
            {
                string newEvent = $"{calendarMain.SelectionStart.ToShortDateString()} - {txt_etkinlik.Text}";
                ListBoxEvents.Items.Add(newEvent);
                txt_etkinlik.Clear();
            }
        }

        private void btnDelClick_Click(object sender, EventArgs e)
        {
            // Delete button click handler
            if (ListBoxEvents.SelectedIndex != -1)
            {
                ListBoxEvents.Items.RemoveAt(ListBoxEvents.SelectedIndex);
            }
        }

        private void btnSignClick_Click(object sender, EventArgs e)
        {
            // Mark/Sign button click handler
            if (ListBoxEvents.SelectedIndex != -1)
            {
                int index = ListBoxEvents.SelectedIndex;
                string item = ListBoxEvents.Items[index].ToString();
                ListBoxEvents.Items[index] = "✓ " + item;
            }
        }

        private void btnExitClick_Click(object sender, EventArgs e)
        {
            // Exit button click handler
            Application.Exit();
        }
        //Ve buraya kadar silinecek


        private void btnActivityAdd_Click_1(object sender, EventArgs e)
        {
            DateTime scilenTarih = calendarMain.SelectionStart;

            string etkinlik = txt_etkinlik.Text.Trim();

            if (!etkinlikler.ContainsKey(scilenTarih))
            {
                etkinlikler[secilenTarih] = new List<string>();

                etkinlikler[secilenTarih].Add(etkinlik);

                EtkinliklerGoster(scilenTarih);
                txt_etkinlik.Clear();

            }
            else
            {
                MessageBox.Show("Lütfen Bir Etkinlik Giriniz : ");

            }
        }

        private void EtkinliklerGoster(DateTime tarih)
        {
            ListBoxEvents.Items.Clear();
            if (etkinlikler.ContainsKey(tarih))
            {
                foreach (var etkinlik in etkinlikler[tarih])
                {
                    ListBoxEvents.Items.Add(etkinlik);
                }
            }
            else
            {
                ListBoxEvents.Items.Add("Etkinlik Bulunamadı");

            }

        }

        private void btnTodayClick_Click_1(object sender, EventArgs e)
        {
            calendarMain.SetDate(DateTime.Today);
            EtkinliklerGoster(DateTime.Today);
        }

        private void btnExitClick_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "Cıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void EtkinklikleriKaydet()
        {
            string dosyaYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\etkinlikler.txt";

            using (StreamWriter writer = new StreamWriter(dosyaYolu))
            {
                foreach (var tarih in etkinlikler.Keys)
                {
                    foreach (var etkinlik in etkinlikler[tarih])
                    {
                        writer.WriteLine($"{tarih:yyyy-MM-dd}|{etkinlik}");
                    }
                }
            }

        }

        private void EtkinlikleriYukle()
        {
            string dosyaYolu = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\etkinlikler.txt";

            if (!(File.Exists(dosyaYolu))) return;

            using (StreamReader reader = new StreamReader(dosyaYolu))
            {
                string satir = reader.ReadLine();
                string[] parcalar=satir.Split('|');
                if(DateTime.TryParse(parcalar[0],out DateTime tarih))
                {
                    if(!etkinlikler.ContainsKey(tarih))
                    {
                        etkinlikler[tarih] = new List<string>();
                        etkinlikler[tarih].Add(parcalar[1]);
                    }               
                }

            }
        }

        private void lblMyAgenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            EtkinklikleriKaydet();
        }

        private void calendarMain_DateChanged(object sender, DateRangeEventArgs e)
        {
            EtkinliklerGoster(calendarMain.SelectionStart);
        }
    }
}

