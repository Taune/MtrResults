using System;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Net;
using System.Windows.Forms;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.IO;
using System.Threading;
using System.Configuration;
using System.Collections.Generic;


namespace Brikkesjekk
{
    public partial class MainMenu : Form
    {
        private bool _stop = true;
        public static string ActiveUsbPort;
        public static string MTRComPortOpen = "";
        public static string ECUComPortOpen = "";
        public string NavnScrollInfo = "";
        public string ecardRead;
        public bool _ecardfound;
        public bool _serialportfound;
        private bool _fileloaded = false;
        public double _batterylevel;
        public Color _batterycolor;
        public string _EcuCode;
        private int _blink = 0;
        DataTable TotalResultGridTable = new DataTable();
        DataTable EcardResultGridTable = new DataTable();
        SerialPortManager _spManager;
        
        public class Competition
        {
            public int id { get; set; }
            public string name { get; set; }
            public string organizer { get; set; }
            public string date { get; set; }
            public int timediff { get; set; }
            public int multidaystage { get; set; }
            public int multidayfirstday { get; set; }
        }

        public class RootObject
        {
            public List<Competition> competitions { get; set; }                
        }

        public class ExThread
        {
            // Non-static method
            public void mythread1()
            {
                          
            }
        }

        public MainMenu()
        {
            InitializeComponent();
            UserInitialization();
        }

        private void UserInitialization()
        {
            _spManager = new SerialPortManager();
            _spManager.NewSerialDataRecievedMTR += new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecievedMTR);

            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Update config file when exit
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection app = config.AppSettings;
            config.Save(ConfigurationSaveMode.Modified);

            if (_serialportfound == true)
            {
                _spManager.Dispose();
            }
            else
            {
            }
            //this.Close();
        }
       
        void _spManager_NewSerialDataRecievedMTR(object sender, SerialDataEventArgs e)
        {

            if (this.InvokeRequired)
            {
                // Using this.Invoke causes deadlock when closing serial port, and BeginInvoke is good practice anyway.
                this.BeginInvoke(new EventHandler<SerialDataEventArgs>(_spManager_NewSerialDataRecievedMTR), new object[] { sender, e });
                return;
            }
            string strMessage = Encoding.ASCII.GetString(e.Data);

            if (_spManager._MtrEcardfound == true && _fileloaded == true)
            {
                //strMessage = ecardRead;
                //SearchEcard(strMessage);
                ReadMtrResultFile(SearchCard_Txtbox.Text);
                FindEcardInGrid(SearchCard_Txtbox.Text);
                UsbRead_listBox.Items.Insert(0, "MTR - " + DateTime.Now.ToString("HH:mm:ss") + " " + strMessage + NavnScrollInfo);
                _spManager._MtrEcardfound = false;
            }
            if (_spManager._MtrEcardfound == true && _fileloaded == false)
            {
                //strMessage = ecardRead;
                UnknownEcard(strMessage);
                ReadMtrResultFile(strMessage);
                FindEcardInGrid(strMessage);


                UsbRead_listBox.Items.Insert(0, "MTR - " + DateTime.Now.ToString("HH:mm:ss") + " " + strMessage + " - brikkesjekkfil ikke lest");
                _spManager._MtrEcardfound = false;
            }
        }

        private void btnReadMTR_Click(object sender, EventArgs e) //Read MTR
        {
            if (ActiveUsbPort == null)
            {
                MessageBox.Show("Brikkeleser ikke funnet! Koble til brikkeleser og trykk 'Oppfrisk'", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (btnStartMTR.Text == "START MTR")
                {
                    //Check if COM-port already opened 
                    if (ECUComPortOpen == ActiveUsbPort)
                    {
                        MessageBox.Show("COM-port " + ActiveUsbPort + " i bruk. Velg annen COM-port!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        btnStartMTR.Text = "STOPP MTR";
                        btnStartMTR.BackColor = Color.LightSeaGreen;
                        UsbRead_listBox.Items.Insert(0, "MTR - " + DateTime.Now.ToString("HH:mm:ss") + "  Open Communication");
                        MTR_read_led.Color = Color.FromArgb(153, 255, 54); //LightGreen
                        MTR_read_led_Click(MTR_read_led, new EventArgs());
                        _spManager.StartListeningMTR();
                        _stop = false;
                    }
                }
                else
                {
                    btnStartMTR.Text = "START MTR";
                    btnStartMTR.BackColor = Color.DodgerBlue;
                    _spManager.StopListeningMTR();
                    UsbRead_listBox.Items.Insert(0, "MTR - " + DateTime.Now.ToString("HH:mm:ss") + "  Communication Closed");
                    MTRComPortOpen = "";
                    _stop = true;
                    MTR_read_led.Color = Color.Red;
                    MTR_read_led_Click(MTR_read_led, new EventArgs());
                    MTR_read_led.On = true;
                }
            }
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports != null && ports.Length != 0)
            {
                UsbPort_listBox.Items.AddRange(ports);
                UsbPort_listBox.SelectedIndex = 0;
                _serialportfound = true;
            }
            else
            {
                UsbPort_listBox.Items.Add("COM-port ikke funnet");
                _serialportfound = false;
            }
            Close_btn.Enabled = true;
        }

         
        private void UsbPort_listBox_SelectedIndexChanged(object sender, EventArgs e) //Velger ønsket Usb Port
        {
            ActiveUsbPort = UsbPort_listBox.GetItemText(UsbPort_listBox.SelectedItem);
        }

        private void RefreshUsbPort_btn_Click(object sender, EventArgs e) //Oppdaterer Usb Port-liste
        {
            UsbPort_listBox.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            if (ports != null && ports.Length != 0)
            {
                _serialportfound = true;
                UsbPort_listBox.Items.AddRange(ports);
                UsbPort_listBox.SelectedIndex = 0;
            }
            else
            {
                _serialportfound = false;
                UsbPort_listBox.Items.Add("COM-port ikke funnet");
            }
        }

        private void Close_btn_Click(object sender, EventArgs e) //Close MainMenu form
        {
            if (_stop == false)
            {
                return;
            }
            else
            {
                _stop = true;
                if (_serialportfound == true)
                {
                    Thread.Sleep(100); //Stops thread to ensure USB-reading is ended
                    try
                    {
                        _spManager.Dispose();
                    }
                    catch
                    {
                    }
                }
            }

            //Update config file when exit
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppSettingsSection app = config.AppSettings;
            config.Save(ConfigurationSaveMode.Modified);

            System.Windows.Forms.Application.ExitThread();
            this.Close();
        }

        private void SearchCard_btn_Click(object sender, EventArgs e) //Manually search after ecard number
        {
            if (SearchCard_Txtbox.Text != "")
            {
                ReadMtrResultFile(SearchCard_Txtbox.Text);
                FindEcardInGrid(SearchCard_Txtbox.Text);
            }
            else
            {
                MessageBox.Show("Brikkefelt er tomt!", "Feilmelding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UnknownEcard(string ecardname) //Ecard not found - Write "Ukjent brikke"
        {
            if (Ecard_box != null && !Ecard_box.IsDisposed)
            {
                Ecard_box.BeginInvoke(new MethodInvoker(delegate
                {
                    Ecard_box.ForeColor = Color.Red;
                    Ecard_box.Text = ecardname;
            
                }));
            }
            if (SearchCard_Txtbox != null && !SearchCard_Txtbox.IsDisposed)
            {
                SearchCard_Txtbox.BeginInvoke(new MethodInvoker(delegate
                {
                    SearchCard_Txtbox.Text = ecardname;
                }));
            }
         }

        public void EmitagParser(string ecbMessage) //Split the message from ECU and find Ecard number
        {
            //Statusmelding fra ECU (ikke lest brikke):
            //IECU - HW1 - SW5 - V1.72  M1 - 103  Y878100473 W12:00:42.216   C253 X7
            //Brikke lest fra ECU:
            //D-02 05	N3903382	Y878100473	W12:00:36.391	V301-2082	S3903382	RemiTag II	L0112	X7
            string _batteryVolt;

            string[] ecbText = ecbMessage.Split(new[] { "\t" }, StringSplitOptions.None);

            foreach (string s in ecbText)
            {
                char type = s[0];
                string info = s.Substring(1);
                switch (type)
                {
                    case 'M':
                        {           // number of messages today
                            //ecardRead = ecbMessage;
                            break;
                        }
                    case 'I':
                        {           // unit info (HW/SW)
                            //ecardRead = info;
                            break;
                        }
                    case 'N':
                        {          // EmiTag-No
                            ecardRead = info;
                            _ecardfound = true;
                            break;
                        }
                    case 'C':
                        {           // ECU internal code
                            _EcuCode = info;
                            
                            break;
                        }
                    case 'W':
                        {           // Clock - when the message was sent
                            break;
                        }
                    case 'A':
                        { // unit health
                            break;
                        }
                    case 'V':
                        {   //Battery status
                            _batteryVolt = info.Substring(0, 1) + "," + info.Substring(1, 2);
                            _batterylevel = Convert.ToDouble(_batteryVolt);
                            break;
                        }
                }
            }
        }
       
        private void SearchEcard(string searchString) //Search for Ecard in "Ecard1" and "Ecard2"
        {
            try
            {
                bool _valueFound = false;
                if (_valueFound == false)
                {
                    UnknownEcard(searchString);
                    NavnScrollInfo = " - Ukjent brikke";
                }
            }
            catch (Exception) //Ecard not found in datagrid
            {
                UnknownEcard(searchString);
                NavnScrollInfo = " - Ukjent brikke";
            }
        }
        
        private void SearchCard_Txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SearchCard_btn.PerformClick();
            }
        }

        private void MTR_read_led_Click(object sender, EventArgs e)
        {
            if (_blink == 0) _blink = 500;
            else _blink = 0;
            ((LedBulb)sender).Blink(_blink);
        }

        private void ReadMtrResultFile(string FindEcard)
        {
            string StartlistFilename;

            if (TotalResultGridTable != null)
            {
                TotalResultGridTable.Columns.Clear();
                TotalResultGridTable.Rows.Clear();
                EcardResultGridTable.Columns.Clear();
                EcardResultGridTable.Rows.Clear();
                //MtrTotalGridview.Refresh();
                //EcardResultGrid.Refresh();
            }

            try
            {
                DataTable TotalResult = new DataTable("Data");
                DataTable EcardResult = new DataTable("Data");
                //using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true, Multiselect = false })
                {
                    StartlistFilename = "c:" + @"\" + "temp" + @"\" + "Results.txt";
                    var connString = string.Format(@"Provider=Microsoft.Jet.OleDb.4.0; Data Source={0};Extended Properties=""Text;HDR=YES;FMT=Delimited""",
                                                    Path.GetDirectoryName(StartlistFilename));

                    using (var cn = new OleDbConnection(connString))
                    {
                        cn.Open();
                        var query1 = "SELECT * FROM [" + Path.GetFileName(StartlistFilename) + "] ORDER BY time ";
                        using (var adapter = new OleDbDataAdapter(query1, cn))
                        {
                            adapter.Fill(TotalResult);
                        }
                        var query2 = "SELECT * FROM [" + Path.GetFileName(StartlistFilename) + "] WHERE ecard = " + FindEcard + " ORDER BY time";
                        using (var adapter = new OleDbDataAdapter(query2, cn))
                        {
                            adapter.Fill(EcardResult);
                        }
                    }
                }

                TotalResultGridTable.Columns.AddRange(new DataColumn[3] { new DataColumn("Plass", typeof(int)),
                        new DataColumn("Brikkenr", typeof(string)),
                        new DataColumn("Tid (sek)",typeof(int)),});

                EcardResultGridTable.Columns.AddRange(new DataColumn[4] { new DataColumn("Plass", typeof(int)),
                        new DataColumn("Klokkeslett", typeof(DateTime)),
                        new DataColumn("Brikkenr", typeof(string)),
                        new DataColumn("Tid (sek)",typeof(int)),});

                int LinjeNr = 1;
                foreach (DataRow row in TotalResult.Rows)
                {
                    TotalResultGridTable.Rows.Add(LinjeNr, row[1], row[2]);
                    LinjeNr++;
                }

                int LinjeNr2 = 1;
                foreach (DataRow row in EcardResult.Rows)
                {
                    EcardResultGridTable.Rows.Add(LinjeNr2, row[0], row[1], row[2]);
                    LinjeNr2++;
                }

                MtrTotalGridview.DataSource = TotalResultGridTable;
                MtrTotalGridview.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                MtrTotalGridview.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                MtrTotalGridview.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                MtrTotalGridview.RowHeadersWidth = 20;
                MtrTotalGridview.Columns[0].Width = 60;
                MtrTotalGridview.Columns[1].Width = 150;
                EcardGridView.DataSource = EcardResultGridTable;
                EcardGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                EcardGridView.Columns[1].DefaultCellStyle.Format = "HH:mm:ss";
                EcardGridView.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                EcardGridView.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                EcardGridView.RowHeadersWidth = 20;
                EcardGridView.Columns[0].Width = 60;
                EcardGridView.Columns[1].Width = 150;
                EcardGridView.Columns[2].Width = 150;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FindEcardInGrid(string FindEcard)
        {
            string searchValue = FindEcard;
            int rowIndex = 0;
            int jumpvalue = 0;

            foreach (DataGridViewRow row in MtrTotalGridview.Rows)
            {
                if (row.Index < 10)
                {
                    jumpvalue = 0;
                }
                else
                {
                    jumpvalue = row.Index - 10;
                }

                if (row.Cells[1].Value != null)
                {
                    try
                    {
                        if (row.Cells[1].Value.ToString().Equals(searchValue))
                        {
                            rowIndex = row.Index;
                            MtrTotalGridview.ClearSelection();
                            //TotalResultGrid.Rows[rowIndex].Selected = true;
                            MtrTotalGridview.FirstDisplayedScrollingRowIndex = jumpvalue;
                            MtrTotalGridview.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                            MtrTotalGridview.Focus();
                            break;
                        }
                    }
                    catch { }
                }
            }

            if (EcardResultGridTable.Rows.Count > 0)
            {
                var LastResults = EcardResultGridTable.AsEnumerable().Max(row => Convert.ToDateTime(row[1]));
                rowIndex = -1;

                foreach (DataGridViewRow row in EcardGridView.Rows)
                {
                    if (row.Index < 10)
                    {
                        jumpvalue = 0;
                    }
                    else
                    {
                        jumpvalue = row.Index - 10;
                    }
                    try
                    {
                        if (row.Cells[1].Value.Equals(LastResults))
                        {
                            rowIndex = row.Index;
                            EcardGridView.ClearSelection();
                            //TotalResultGrid.Rows[rowIndex].Selected = true;
                            EcardGridView.FirstDisplayedScrollingRowIndex = jumpvalue;
                            EcardGridView.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                            EcardGridView.Focus();
                            break;
                        }
                    }
                    catch { }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReadMtrResultFile(SearchCard_Txtbox.Text);
            FindEcardInGrid(SearchCard_Txtbox.Text);
        }

    }
}