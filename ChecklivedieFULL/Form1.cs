using DeviceId;
using Newtonsoft.Json.Linq;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Schema;
using xNet;
using ChecklivedieFULL.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ChecklivedieFULL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InfoApp();
            security();
        }
        private int live = 0;
        private int die = 0;
        private int tientrinhchay = 0;
        private int loi = 0;
        private bool StopThread;
        private int soluongdangchay;
        private string Outputlivedie = "";
        private int kieudungproxy;
        private List<string> listmailchecklivedie = new List<string>();
        private List<string> listmailchecklivedieproxy = new List<string>();
        public static List<string> ListProxy2 = new List<string>();
        public static List<string> listprx = new List<string>();
        public static List<string> test = new List<string>();
        public static List<string> token = new List<string>();
        static string[] firstNames = {
        "John", "Mary", "David", "Sarah", "Michael", "Emily", "James", "Emma", "William", "Olivia",
        "Robert", "Sophia", "Joseph", "Ava", "Daniel", "Isabella", "Matthew", "Mia", "Alexander", "Abigail",
        "Ethan", "Ella", "Christopher", "Grace", "Andrew", "Chloe", "Joshua", "Lily", "Matthew", "Sophie",
        "Nicholas", "Avery", "Benjamin", "Natalie", "Samuel", "Zoe", "Tyler", "Hannah", "Daniel", "Evelyn",
        "Alexander", "Victoria", "William", "Madison", "Matthew", "Eleanor", "Henry", "Sofia", "Anthony", "Aubrey",
        "David", "Scarlett", "Joseph", "Grace", "Christopher", "Aria", "Jackson", "Mila", "Logan", "Layla"
        // Thêm nhiều tên khác ở đây
        };

        static string[] lastNames = {
        "Smith", "Johnson", "Brown", "Jones", "Davis", "Wilson", "Taylor", "Anderson", "Miller", "Thomas",
        "Moore", "Jackson", "Harris", "White", "Clark", "Young", "Lee", "Walker", "Lewis", "Hall",
        "Allen", "Baker", "Carter", "Cook", "Cooper", "Evans", "Garcia", "Hill", "Howard", "King",
        "Martin", "Martinez", "Perez", "Roberts", "Robinson", "Scott", "Turner", "Wright", "Young",
        "Adams", "Bell", "Campbell", "Diaz", "Fisher", "Green", "Jones", "Kelly", "Lopez", "Morgan",
        "Parker", "Reed", "Russell", "Smith", "Taylor", "White", "Williams", "Wilson", "Young"
        // Thêm nhiều họ khác ở đây
        };
        void InfoApp()
        {
            try
            {
                string key = new DeviceIdBuilder().
                    AddMachineName().AddProcessorId().AddMotherboardSerialNumber()
                                                .AddSystemDriveSerialNumber()
                                                .ToString();
                using (var sha = new System.Security.Cryptography.SHA256Managed())
                {
                    byte[] textData = System.Text.Encoding.UTF8.GetBytes("GMAIL" + key);
                    byte[] hash = sha.ComputeHash(textData);
                    textBox1.Text = "GMAIL" + (BitConverter.ToString(hash).Replace("-", String.Empty)).ToString().Substring(0, 22);
                }
            }
            catch { }
        }
        void security()
        {
            HttpClient httpClient = new HttpClient();
            string text2 = textBox1.Text.ToString();
            string requestUri2 = "https://docs.google.com/spreadsheets/d/19Pes-M_k9QepwX0aNFqKU3khq6yDtfKEl5JSD3SXok0/edit?usp=sharing";
            string text3 = httpClient.GetAsync(requestUri2).Result.Content.ReadAsStringAsync().Result.ToString();
            Match match2 = Regex.Match(text3.ToString(), text2 + ".*?(?=ok)");
            bool flag2 = match2 != Match.Empty;
            if (flag2)
            {
                string[] array = match2.ToString().Split(new char[]
                {
                            '|'
                });
                string[] arrays2 = array[2].ToString().Split(new char[]
               {
                            '/'
               });
                int dayn = Int32.Parse(arrays2[0]);
                int monthn = Int32.Parse(arrays2[1]);
                int yearn = Int32.Parse(arrays2[2]);

                string[] arrays = array[1].ToString().Split(new char[]
               {
                            '/'
               });
                int dayt = Int32.Parse(arrays[0]);
                int montht = Int32.Parse(arrays[1]);
                int yeart = Int32.Parse(arrays[2]);
                System.DateTime now = new System.DateTime(yearn, monthn, dayn);
                System.DateTime then = new System.DateTime(yeart, montht, dayt);
                System.TimeSpan diff1 = then.Subtract(now);
                int days = (int)Math.Ceiling(diff1.TotalDays);
                if (days <= 0)
                {
                    label5.Text = "Hết hạn";
                    btn_start.Enabled = false;
                    btn_stop.Enabled = false;
                    txt_status.Enabled = false;
                    groupBox5.Enabled = false;
                    label5.ForeColor = Color.PaleVioletRed;
                }
                else if (days > 2000000)
                {
                    label5.Text = "Vĩnh viễn";
                }
                else if (days > 0)
                {
                    label5.Text = $"Còn {days} ngày";
                }
            }
            else
            {
                label5.Text = "Chưa kích hoạt";
                btn_start.Enabled = false;
                btn_stop.Enabled = false;
                txt_status.Enabled = false;
                groupBox5.Enabled = false;
                label5.ForeColor = Color.PaleVioletRed;
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SaveMail(string path, string content)
        {
            try
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    File.AppendAllText(path, content + "\r\n");
                }));
            }
            catch { }
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            if (listmailchecklivedie.Count == 0)
            {
                MessageBox.Show("Vui lòng import List mail !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (dungproxycheck.Checked)
                {
                    if (listprx.Count == 0)
                    {
                        MessageBox.Show("Vui lòng thêm list proxy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (loaiproxy.SelectedIndex < 0)
                    {
                        MessageBox.Show("Vui lòng chọn loại Proxy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    kieudungproxy = loaiproxy.SelectedIndex;
                }
                else
                {
                    kieudungproxy = 3;
                }
                txt_status.Clear();
                StopThread = false;
                tonglive.Text = "0";
                tongdie.Text = "0";
                tongloi.Text = "0";
                tientrinhchay = 0;
                live = 0;
                die = 0;
                loi = 0;
                btn_start.Enabled = false;
                string DateFormat = DateTime.Now.ToString("dd-MM-yyy hh-mm-ss");
                Outputlivedie = Application.StartupPath + @"\Outputlivedie\Result " + DateFormat;
                string Filedie = Outputlivedie + @"\Mail_die.txt";
                string Filelive = Outputlivedie + @"\Mail_live.txt";
                string Fileloi = Outputlivedie + @"\Error_Mail.txt";
                if (!Directory.Exists(Outputlivedie))
                {
                    Directory.CreateDirectory(Outputlivedie);
                }
                Thread a = new Thread(() => 
                {
                    //string TL = GetTLGoogle(listprx[new Random().Next(0, listprx.Count)]);
                    soluongdangchay = 0;
                    for (int i = (int)chaytumailso.Value - 1; i < listmailchecklivedie.Count; i++)
                    {
                        if (StopThread)
                        {
                            break;
                        }
                        while (!StopThread)
                        {
                            if (soluongdangchay < (int)soluongtoida.Value)
                            {
                                break;
                            } 
                            Thread.Sleep(500);
                        }
                        Hamchaychecklivedie(i, listmailchecklivedie[i], Filedie, Filelive, Fileloi);
                        soluongdangchay++;
                    }
                    while (!StopThread)
                    {
                        if (soluongdangchay <= 0)
                        {
                            break;
                        }
                    }
                    GC.SuppressFinalize(this);
                    GC.WaitForFullGCApproach();
                    GC.WaitForPendingFinalizers();
                    GC.Collect();
                    base.Invoke(new MethodInvoker(delegate ()
                    {
                        btn_start.Enabled = true;
                        MessageBox.Show("Đã chạy xong !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }));
                }); 
                a.Start();
                a.IsBackground = true;
            }
            catch { }
        }
        void Hamchaychecklivedie(int i, string email,string Filedie, string Filelive, string Fileloi)
        {
            Thread a = new Thread(() =>
            {
                try
                {
                    if (!email.Contains("@") || email.Contains("_") || email.Contains("-"))
                    {
                        loi++;
                        TrangThai(email + " -> Sai định dạng", "");
                        SaveMail(Fileloi, email);
                    }
                    else
                    {
                        for (int m = 0; m < 20; m++)
                        {
                            if (StopThread)
                            {
                                break;
                            }
                            string proxy_use = "";
                            if (dungproxycheck.Checked)
                            {
                                proxy_use = m <= 3 ? listprx[(i / 1) % listprx.Count] : listprx[new Random().Next(0, listprx.Count)];
                            }
                            string reponse = GetKetQualivedie3(email, proxy_use);
                            if (reponse == null)
                            {
                                if (m == 18)
                                {
                                    loi++;
                                    TrangThai(email + " -> Ko xđ", "");
                                    SaveMail(Fileloi, email);
                                    break;
                                }
                                else
                                {
                                    TrangThai($"{email}" + " -> Ko xđ, đang check lại..", "");
                                }
                            }
                            else if (reponse == "Error")
                            {
                                if (m == 18)
                                {
                                    loi++;
                                    TrangThai(email + " -> Block ip", "");
                                    SaveMail(Fileloi, email);
                                    break;
                                }
                                else
                                {
                                    TrangThai($"{email}" + " -> Block ip, check lại..", "");
                                }
                            }
                            else if (reponse == "Live")
                            {
                                live++;
                                TrangThai(email + " -> Live", "");
                                SaveMail(Filelive, email + " -> Live");
                                break;
                            }
                            else if (reponse == "Die")
                            {
                                die++;
                                TrangThai(email + " -> Die", "");
                                SaveMail(Filedie, email + " -> Die");
                                break;
                            }
                            //string TL = GetTLGoogle(proxy_use);
                            //if (TL == null)
                            //{
                            //    if (m == 18)
                            //    {
                            //        loi++;
                            //        TrangThai(email + " -> Ko xđ", "");
                            //        SaveMail(Fileloi, email);
                            //        break;
                            //    }
                            //    else
                            //    {
                            //        TrangThai(email + " -> Ko xđ, đang check lại..", "");
                            //    }
                            //}
                            //else
                            //{
                            //    string reponse = GetKetQualivedie3(email, TL, proxy_use);
                            //    if (reponse == null)
                            //    {
                            //        if (m == 18)
                            //        {
                            //            loi++;
                            //            TrangThai(email + " -> Ko xđ", "");
                            //            SaveMail(Fileloi, email);
                            //            break;
                            //        }
                            //        else
                            //        {
                            //            TrangThai($"{email}" + " -> Ko xđ, đang check lại..", "");
                            //        }
                            //    }
                            //    else if (reponse == "Error")
                            //    {
                            //        if (m == 18)
                            //        {
                            //            loi++;
                            //            TrangThai(email + " -> Block ip", "");
                            //            SaveMail(Fileloi, email);
                            //            break;
                            //        }
                            //        else
                            //        {
                            //            TrangThai($"{email}" + " -> Block ip, check lại..", "");
                            //        }
                            //    }
                            //    else if (reponse == "Live")
                            //    {
                            //        live++;
                            //        TrangThai(email + " -> Live", "");
                            //        SaveMail(Filelive, email + " -> Live");
                            //        break;
                            //    }
                            //    else if (reponse == "Die")
                            //    {
                            //        die++;
                            //        TrangThai(email + " -> Die", "");
                            //        SaveMail(Filedie, email + " -> Die");
                            //        break;
                            //    }
                            //}
                        }
                    }
                }
                catch
                {
                    loi++;
                    TrangThai(email + " -> Ko xd", "");
                    SaveMail(Fileloi, email + "  -> Ko xd");
                }
                tientrinhchay++;
                UpdateDatachecklivedie();
                soluongdangchay--;
            });
            a.Start();
        }
        private string GetKetQualivedie3(string email, string proxy_use)
        {
            try
            {
                HttpRequest request = new HttpRequest();
                if (dungproxycheck.Checked)
                {
                    if (kieudungproxy == 0)
                    {
                        request.Proxy = HttpProxyClient.Parse(proxy_use);
                    }
                    else if (kieudungproxy == 1)
                    {
                        request.Proxy = Socks4ProxyClient.Parse(proxy_use);
                    }
                    else if (kieudungproxy == 2)
                    {
                        request.Proxy = Socks5ProxyClient.Parse(proxy_use);
                    }
                }
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/121.0.0.0 Safari/537.36";
                request.AddHeader("authority", "accounts.google.com");
                request.AddHeader("accept", "*/*");
                request.AddHeader("accept-language", "vi");
                request.AddHeader("origin", "https://accounts.google.com");
                request.AddHeader("referer", "https://accounts.google.com/");
                request.AddHeader("sec-ch-ua", "\"Not A(Brand\";v=\"99\", \"Google Chrome\";v=\"121\", \"Chromium\";v=\"121\"");
                request.AddHeader("sec-ch-ua-arch", "\"x86\"");
                request.AddHeader("sec-ch-ua-bitness", "\"64\"");
                request.AddHeader("sec-ch-ua-full-version", "\"121.0.6167.187\"");
                request.AddHeader("sec-ch-ua-full-version-list", "\"Not A(Brand\";v=\"99.0.0.0\", \"Google Chrome\";v=\"121.0.6167.187\", \"Chromium\";v=\"121.0.6167.187\"");
                request.AddHeader("sec-ch-ua-mobile", "?0");
                request.AddHeader("sec-ch-ua-model", "\"\"");
                request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
                request.AddHeader("sec-ch-ua-platform-version", "\"10.0.0\"");
                request.AddHeader("sec-ch-ua-wow64", "?0");
                request.AddHeader("sec-fetch-dest", "empty");
                request.AddHeader("sec-fetch-mode", "cors");
                request.AddHeader("sec-fetch-site", "same-origin");
                request.AddHeader("x-goog-ext-278367001-jspb", "[\"GlifWebSignIn\"]");
                request.AddHeader("x-goog-ext-391502476-jspb", "[\"S-419247689:1708617872619309\",\"mail\",null,\"ATuJsjyOMaHTGoIp_BYVagyo954QHUSfV1W4nVTpkscv_dKjbVaf9LCLexLrPkGo4Lwz9W9Qbt-89Q\"]");
                request.AddHeader("x-same-domain", "1");
                request.AddHeader("Cookie", "__Host-GAPS=1:9UZIEOEQwS-rs4PiX5Trm8_VH7PAug:UuluzGEbi8w56ywZ");
                var body = $"f.req=%5B%5B%5B%22NHJMOd%22%2C%22%5B%5C%22{email.Split('@')[0]}%5C%22%2C0%2C0%2C1%2C%5Bnull%2Cnull%2Cnull%2Cnull%2C0%2C6188%5D%2C0%2C40%5D%22%2Cnull%2C%22generic%22%5D%5D%5D&at=AGxDo0fh4tx4gOiWxy_tZt13rozT%3A1708617881328&";
                string reponse = request.Post($"https://accounts.google.com/lifecycle/_/AccountLifecyclePlatformSignupUi/data/batchexecute?rpcids=NHJMOd&source-path=%2Flifecycle%2Fsteps%2Fsignup%2Fusername&f.sid=-8388851310999860350&bl=boq_identity-account-creation-evolution-ui_20240221.03_p0&hl=vi&TL=ADg0xR3C3Xa2gMLeQHWb5wmXbmBA9l4_1J4UdfX88Vc2DJQ6t4QPiV71ULpgLWML", body, "application/x-www-form-urlencoded;charset=UTF-8").ToString();
                //var body = $"f.req=%5B%5B%5B%22NHJMOd%22%2C%22%5B%5C%22{email.Split('@')[0]}%5C%22%2C0%2C0%2C1%2C%5Bnull%2Cnull%2Cnull%2Cnull%2C0%2C6188%5D%2C0%2C40%5D%22%2Cnull%2C%22generic%22%5D%5D%5D&at=AGxDo0fh4tx4gOiWxy_tZt13rozT%3A1708617881328&";
                //string reponse = request.Post($"https://accounts.google.com/lifecycle/_/AccountLifecyclePlatformSignupUi/data/batchexecute?rpcids=NHJMOd&source-path=%2Flifecycle%2Fsteps%2Fsignup%2Fusername&f.sid=-8388851310999860350&bl=boq_identity-account-creation-evolution-ui_20240221.03_p0&hl=vi&TL={TL}", body, "application/x-www-form-urlencoded;charset=UTF-8").ToString();
                if (reponse.Contains("\"wrb.fr\",\"NHJMOd\",\"[null,") ||reponse.Contains("\"gf.uar\",3") || reponse.Contains("\"gf.uar\",2,\"TL:A"))
                {
                    return "Live";
                }
                else if (reponse.Contains("\"gf.uar\",1") || reponse.Contains("steps/signup/password"))
                {
                    return "Die";
                }
                else
                {
                    return "Error";
                }
            }
            catch { }
            return null;
        }
        void testaa()
        {
            HttpRequest request = new HttpRequest();
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/121.0.0.0 Safari/537.36";
            request.AddHeader("authority", "accounts.google.com");
            request.AddHeader("accept", "*/*");
            request.AddHeader("accept-language", "vi");
            request.AddHeader("origin", "https://accounts.google.com");
            request.AddHeader("referer", "https://accounts.google.com/");
            request.AddHeader("sec-ch-ua", "\"Not A(Brand\";v=\"99\", \"Google Chrome\";v=\"121\", \"Chromium\";v=\"121\"");
            request.AddHeader("sec-ch-ua-arch", "\"x86\"");
            request.AddHeader("sec-ch-ua-bitness", "\"64\"");
            request.AddHeader("sec-ch-ua-full-version", "\"121.0.6167.187\"");
            request.AddHeader("sec-ch-ua-full-version-list", "\"Not A(Brand\";v=\"99.0.0.0\", \"Google Chrome\";v=\"121.0.6167.187\", \"Chromium\";v=\"121.0.6167.187\"");
            request.AddHeader("sec-ch-ua-mobile", "?0");
            request.AddHeader("sec-ch-ua-model", "\"\"");
            request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
            request.AddHeader("sec-ch-ua-platform-version", "\"10.0.0\"");
            request.AddHeader("sec-ch-ua-wow64", "?0");
            request.AddHeader("sec-fetch-dest", "empty");
            request.AddHeader("sec-fetch-mode", "cors");
            request.AddHeader("sec-fetch-site", "same-origin");
            request.AddHeader("x-goog-ext-278367001-jspb", "[\"GlifWebSignIn\"]");
            request.AddHeader("x-goog-ext-391502476-jspb", "[\"S-419247689:1708617872619309\",\"mail\",null,\"ATuJsjyOMaHTGoIp_BYVagyo954QHUSfV1W4nVTpkscv_dKjbVaf9LCLexLrPkGo4Lwz9W9Qbt-89Q\"]");
            request.AddHeader("x-same-domain", "1");
            request.AddHeader("Cookie", "__Host-GAPS=1:9UZIEOEQwS-rs4PiX5Trm8_VH7PAug:UuluzGEbi8w56ywZ");
            var body = @"f.req=%5B%5B%5B%22NHJMOd%22%2C%22%5B%5C%22mkawmkaaaaaaa%5C%22%2C0%2C0%2C1%2C%5Bnull%2Cnull%2Cnull%2Cnull%2C0%2C6188%5D%2C0%2C40%5D%22%2Cnull%2C%22generic%22%5D%5D%5D&at=AGxDo0fh4tx4gOiWxy_tZt13rozT%3A1708617881328&";
            string reponse = request.Post($"https://accounts.google.com/lifecycle/_/AccountLifecyclePlatformSignupUi/data/batchexecute?rpcids=NHJMOd&source-path=%2Flifecycle%2Fsteps%2Fsignup%2Fusername&f.sid=-8388851310999860350&bl=boq_identity-account-creation-evolution-ui_20240221.03_p0&hl=vi&TL=ADg0xR3C3Xa2gMLeQHWb5wmXbmBA9l4_1J4UdfX88Vc2DJQ6t4QPiV71ULpgLWML", body, "application/x-www-form-urlencoded;charset=UTF-8").ToString();

        }
        private string GetKetQualivedie2(string email, string TL, string proxy_use)
        {
            try
            {
                HttpRequest request = new HttpRequest();
                if (dungproxycheck.Checked)
                {
                    if (kieudungproxy == 0)
                    {
                        request.Proxy = HttpProxyClient.Parse(proxy_use);
                    }
                    else if (kieudungproxy == 1)
                    {
                        request.Proxy = Socks4ProxyClient.Parse(proxy_use);
                    }
                    else if (kieudungproxy == 2)
                    {
                        request.Proxy = Socks5ProxyClient.Parse(proxy_use);
                    }
                }
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36";
                request.AddHeader("authority", "accounts.google.com");
                request.AddHeader("accept", "*/*");
                request.AddHeader("accept-language", "en-US,en;q=0.9,vi;q=0.8");
                request.AddHeader("google-accounts-xsrf", "1");
                request.AddHeader("origin", "https://accounts.google.com");
                request.AddHeader("referer", $"https://accounts.google.com/signup/v2/createusername?TL={TL}&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&dsh=S-1325370260%3A1705135457508108&ec=asw-gmail-globalnav-create&flowEntry=SignUp&flowName=GlifWebSignIn&hl=en-US&service=mail&theme=glif");
                request.AddHeader("sec-ch-ua", "\"Not_A Brand\";v=\"8\", \"Chromium\";v=\"120\", \"Google Chrome\";v=\"120\"");
                request.AddHeader("sec-ch-ua-arch", "\"x86\"");
                request.AddHeader("sec-ch-ua-bitness", "\"64\"");
                request.AddHeader("sec-ch-ua-full-version", "\"120.0.6099.217\"");
                request.AddHeader("sec-ch-ua-full-version-list", "\"Not_A Brand\";v=\"8.0.0.0\", \"Chromium\";v=\"120.0.6099.217\", \"Google Chrome\";v=\"120.0.6099.217\"");
                request.AddHeader("sec-ch-ua-mobile", "?0");
                request.AddHeader("sec-ch-ua-model", "\"\"");
                request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
                request.AddHeader("sec-ch-ua-platform-version", "\"10.0.0\"");
                request.AddHeader("sec-ch-ua-wow64", "?0");
                request.AddHeader("sec-fetch-dest", "empty");
                request.AddHeader("sec-fetch-mode", "cors");
                request.AddHeader("sec-fetch-site", "same-origin");
                var body = $"TL={TL}&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&dsh=S-1325370260%3A1705135457508108&ec=asw-gmail-globalnav-create&flowEntry=SignUp&hl=en-US&service=mail&theme=glif&f.req=%5B%22TL%3A{TL}%22%2C%22{email.Split('@')[0]}%22%2C0%2C0%2C1%2Cnull%2C0%2C16541%5D&azt=AFoagUWcTE37BhuaG53MrGtTpblrhVfsHQ%3A1705135505467&cookiesDisabled=false&gmscoreversion=undefined&flowName=GlifWebSignIn&checkConnection=youtube%3A182&checkedDomains=youtube&pstMsg=1&";
                string reponse = request.Post($"https://accounts.google.com/_/signup/usernameavailability?hl=en&TL={TL}", body, "application/x-www-form-urlencoded;charset=UTF-8").ToString();
                if (reponse.Contains("\"gf.uar\",3") || reponse.Contains($"[[[\"gf.uar\",2,\"TL:{TL}\",[]],[\"e\",2,null,null") || reponse.Contains("\"gf.uar\",2,\"TL:A"))
                {
                    return "Live";
                }
                else if (reponse.Contains("\"gf.uar\",1"))
                {
                    return "Die";
                }
                else
                {
                    return "Error";
                }
            }
            catch { }
            return null;
        }
        private string GetKetQualivedie(string email, string TL, string proxy_use)
        {
            try
            {
                HttpRequest request = new HttpRequest();
                if (dungproxycheck.Checked)
                {
                    if (kieudungproxy == 0)
                    {
                        request.Proxy = HttpProxyClient.Parse(proxy_use);
                    }
                    else if (kieudungproxy == 1)
                    {
                        request.Proxy = Socks4ProxyClient.Parse(proxy_use);
                    }
                    else if (kieudungproxy == 2)
                    {
                        request.Proxy = Socks5ProxyClient.Parse(proxy_use);
                    }
                }
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36";
                request.AddHeader("authority", "accounts.google.com");
                request.AddHeader("accept", "*/*");
                request.AddHeader("accept-language", "en-US,en;q=0.9");
                request.AddHeader("google-accounts-xsrf", "1");
                request.AddHeader("origin", "https://accounts.google.com");
                request.AddHeader("sec-ch-ua", "\"Not_A Brand\";v=\"8\", \"Chromium\";v=\"120\", \"Google Chrome\";v=\"120\"");
                request.AddHeader("sec-ch-ua-arch", "\"x86\"");
                request.AddHeader("sec-ch-ua-bitness", "\"64\"");
                request.AddHeader("sec-ch-ua-full-version", "\"120.0.6099.130\"");
                request.AddHeader("sec-ch-ua-full-version-list", "\"Not_A Brand\";v=\"8.0.0.0\", \"Chromium\";v=\"120.0.6099.130\", \"Google Chrome\";v=\"120.0.6099.130\"");
                request.AddHeader("sec-ch-ua-mobile", "?0");
                request.AddHeader("sec-ch-ua-model", "\"\"");
                request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
                request.AddHeader("sec-ch-ua-platform-version", "\"10.0.0\"");
                request.AddHeader("sec-ch-ua-wow64", "?0");
                request.AddHeader("sec-fetch-dest", "empty");
                request.AddHeader("sec-fetch-mode", "cors");
                request.AddHeader("sec-fetch-site", "same-origin");
                request.AddHeader("x-same-domain", "1");
                //request.AddHeader("Cookie", "__Host-GAPS=1:pQAYGHfEjuowDoyrgN-XTm8UH51Mpg:54NGsk18d52U7p8h");
                var body = $"TL={TL}&continue=https%3A%2F%2Fmail.google.com%2Fmail%2Fu%2F0%2F&dsh=S-754746170%3A17036520{new Random().Next(10000000, 99999999)}&emr=1&flowEntry=SignUp&followup=https%3A%2F%2Fmail.google.com%2Fmail%2Fu%2F0%2F&hl=en-US&ifkv=ASKXGp1-cw1CiRaLdl6XOADmKgR8At2hWPLxBL1q-iPlElj3LxNndMae1MCuQp1tYm0EpAGy6xUhkw&osid=1&service=mail&theme=glif&f.req=%5B%22TL%3A{TL}%22%2C%22{email.Split('@')[0]}%22%2C0%2C0%2C1%2Cnull%2C0%2C225139%5D&azt=AFoagUWq4IM5crFvdK5rf-i_awifBCDGhA%3A1703652{new Random().Next(100000, 999999)}&cookiesDisabled=false&deviceinfo=%5Bnull%2Cnull%2Cnull%2Cnull%2Cnull%2C%22VN%22%2Cnull%2Cnull%2Cnull%2C%22GlifWebSignIn%22%2Cnull%2C%5B%5D%2Cnull%2Cnull%2Cnull%2Cnull%2C2%2Cnull%2C0%2C1%2C%22%22%2Cnull%2Cnull%2C2%2C2%5D&gmscoreversion=undefined&flowName=GlifWebSignIn&checkConnection=youtube%3A92&checkedDomains=youtube&pstMsg=1&";
                string reponse = request.Post($"https://accounts.google.com/_/signup/usernameavailability?hl=en&TL={TL}", body, "application/x-www-form-urlencoded;charset=UTF-8").ToString();
                if (reponse.Contains("\"gf.uar\",3") || reponse.Contains($"[[[\"gf.uar\",2,\"TL:{TL}\",[]],[\"e\",2,null,null") || reponse.Contains("\"gf.uar\",2,\"TL:AHN"))
                {
                    return "Live";
                }
                else if (reponse.Contains("\"gf.uar\",1"))
                {
                    return "Die";
                }
                else
                {
                    return "Error";
                }
                //else
                //{
                //    if (i == 4)
                //    {
                //        return null;
                //    }
                //}
            }
            catch { }
            return null;
        }
        private string GetTLGoogle(string proxy_use)
        {
            try
            {
                string firstname = GenerateRandomFirstName();
                string lastname = GenerateRandomLastName();
                HttpRequest request = new HttpRequest();
                request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/116.0.0.0 Safari/537.36";
                if (dungproxycheck.Checked)
                {
                    if (kieudungproxy == 0)
                    {
                        request.Proxy = HttpProxyClient.Parse(proxy_use);
                    }
                    else if (kieudungproxy == 1)
                    {
                        request.Proxy = Socks4ProxyClient.Parse(proxy_use);
                    }
                    else if (kieudungproxy == 2)
                    {
                        request.Proxy = Socks5ProxyClient.Parse(proxy_use);
                    }
                }
                request.AddHeader("authority", "accounts.google.com");
                request.AddHeader("accept", "*/*");
                request.AddHeader("accept-language", "en");
                request.AddHeader("google-accounts-xsrf", "1");
                request.AddHeader("origin", "https://accounts.google.com");
                request.AddHeader("sec-ch-ua", "\"Chromium\";v=\"116\", \"Not)A;Brand\";v=\"24\", \"Google Chrome\";v=\"116\"");
                request.AddHeader("sec-ch-ua-arch", "\"x86\"");
                request.AddHeader("sec-ch-ua-bitness", "\"64\"");
                request.AddHeader("sec-ch-ua-full-version", "\"116.0.5845.188\"");
                request.AddHeader("sec-ch-ua-full-version-list", "\"Chromium\";v=\"116.0.5845.188\", \"Not)A;Brand\";v=\"24.0.0.0\", \"Google Chrome\";v=\"116.0.5845.188\"");
                request.AddHeader("sec-ch-ua-mobile", "?0");
                request.AddHeader("sec-ch-ua-model", "\"\"");
                request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
                request.AddHeader("sec-ch-ua-platform-version", "\"10.0.0\"");
                request.AddHeader("sec-ch-ua-wow64", "?0");
                request.AddHeader("sec-fetch-dest", "empty");
                request.AddHeader("sec-fetch-mode", "cors");
                request.AddHeader("sec-fetch-site", "same-origin");
                request.AddHeader("x-same-domain", "1");
                var body = $"continue=https%3A%2F%2Fmail.google.com%2Fmail%2Fu%2F0%2F&dsh=S-602981047%3A1695356824583245&emr=1&flowEntry=ServiceLogin&followup=https%3A%2F%2Fmail.google.com%2Fmail%2Fu%2F0%2F&ifkv=AYZoVhdB52WXW4YzLFmgAgQKW3mCnit7_7mb88XUKY22Mim4lyeEdgXUWRSyqVnJRCnASbey52bc0Q&osid=1&service=mail&theme=glif&f.req=%5B%22AEThLlwf5eI0qP8CIX1Sh9hLQzFoNhk9jxFyWEOyiNN5ylRKC6oZSel96AM_-BYpB9uVIQj2nKKOaRUMnglqRSXeRtPsKgYRwxZHdXNAKl703AdSJfwGDSMc-MNteudqzxPfrIXSWGNWO0kCFZyVYq3YZdmFU9q0QsVrdyQO6fWBH0uBlTmyOUtq_Q6fxKexyI2SkkF-QFY3%22%2C%22{lastname}%22%2C%22{firstname}%22%2C%22{lastname}%22%2C%22{firstname}%22%2C0%2C1%2Cnull%2Cnull%2C%22web-glif-signup%22%2C0%2Cnull%2C1%2C%5Bnull%2Cnull%2C%5B%5D%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2C%5B%5D%2Cnull%2Cnull%2Cnull%2Cnull%2C%5B%5D%5D%2C1%5D&azt=AFoagUU5o6oJheSa3fBT_sIKfY3HcdXVjQ%3A1695356{new Random().Next(100000, 999999)}&cookiesDisabled=false&deviceinfo=%5Bnull%2Cnull%2Cnull%2C%5B%5D%2Cnull%2C%22VN%22%2Cnull%2Cnull%2Cnull%2C%22GlifWebSignIn%22%2Cnull%2C%5Bnull%2Cnull%2C%5B%5D%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2Cnull%2C%5B%5D%2Cnull%2Cnull%2Cnull%2Cnull%2C%5B%5D%5D%2Cnull%2Cnull%2Cnull%2Cnull%2C2%2Cnull%2C0%2C1%2C%22%22%2Cnull%2Cnull%2C2%2C2%5D&gmscoreversion=undefined&flowName=GlifWebSignIn&checkConnection=youtube%3A68%3A0&checkedDomains=youtube&pstMsg=1&";
                string reponse = request.Post("https://accounts.google.com/_/signup/validatepersonaldetails", body, "application/x-www-form-urlencoded;charset=UTF-8").ToString();
                if (reponse.Contains("\"gf.ttu\",null,\""))
                {
                    string TL = Regex.Match(reponse, "\"gf.ttu\",null,\"(.*?)\"").Groups[1].Value.ToString();
                    if (TL.Length > 0 && TL.StartsWith("A"))
                    {
                        return TL;
                    }
                }
            }
            catch { }
            return null;
        }
        static string GenerateRandomFirstName()
        {
            try
            {
                int randomIndex = new Random().Next(0, firstNames.Length);
                return firstNames[randomIndex];
            }
            catch { }
            return "Hiep";
        }
        static string GenerateRandomLastName()
        {
            try
            {
                int randomIndex = new Random().Next(0, lastNames.Length);
                return lastNames[randomIndex];
            }
            catch { }
            return "Pham";
        }
        private void txt_status_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_status.Lines.Count() >= 2000)
                {
                    txt_status.Clear();
                }
            }
            catch { }
        }

        private void TrangThai(string message, string type)
        {
            try
            {
                if (!tatbangdencheck.Checked)
                {
                    base.Invoke(new MethodInvoker(delegate ()
                    {
                        txt_status.SelectionColor = GetColor(type);
                        txt_status.AppendText(message + "\r\n");
                        txt_status.ScrollToCaret();
                    }));
                }
            }
            catch { }
        }
        public static Color GetColor(string state)
        {
            if (state == "OK")
            {
                return Color.Green;
            }
            if (state == "NOT")
            {
                return Color.Red;
            }
            if (state == "ERROR")
            {
                return Color.Orange;
            }
            if (state == "Trang")
            {
                return Color.LightGray;
            }
            if (state == "Xanhnoi")
            {
                return Color.LightGreen;
            }
            else
            {
                return Color.White;
            }
        }
        private void UpdateDatachecklivedie()
        {
            try
            {
                base.Invoke(new MethodInvoker(delegate ()
                {
                    tonglive.Text = live.ToString();
                    tongdie.Text = die.ToString();
                    tongloi.Text = loi.ToString();
                    tientrinh2.Text = tientrinhchay.ToString();
                }));
            }
            catch { }
        }
        private void từClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                listmailchecklivedie.Clear();
                string text = Clipboard.GetText(TextDataFormat.Text);
                listmailchecklivedie = text.Split(new string[]
                {
                    "\r\n",
                    "\r",
                    "\n"
                }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
                listmailchecklivedie = listmailchecklivedie.Distinct().ToList();
                tongmailcheck.Text = Convert.ToString(listmailchecklivedie.Count);
                tientrinh2.Text = $"0";
                MessageBox.Show($"Đã import thành công {listmailchecklivedie.Count} mail", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            StopThread = true;
        }

        private void từClipboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/hieppham1812/");
        }

        private void xóaListMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                listmailchecklivedie.Clear();
                txt_status.Clear();
                MessageBox.Show($"Đã xóa list mail", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tongmailcheck.Text = listmailchecklivedie.Count.ToString();
            }
            catch { }
        }

        private void xóaListProxyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(Directory.GetCurrentDirectory() + "\\Outputlivedie");
            }
            catch
            {
                MessageBox.Show("Không thể mở folder save , vui lòng check lại !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void từFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Add List Mail";
            opf.Filter = "Text |*.txt";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                listmailchecklivedie.Clear();
                listmailchecklivedie = new List<string>(File.ReadAllLines(opf.FileName).ToList<string>());
                listmailchecklivedie.RemoveAll(string.IsNullOrWhiteSpace);
                listmailchecklivedie = listmailchecklivedie.Distinct().ToList();
                opf.Dispose();
            }
            tongmailcheck.Text = Convert.ToString(listmailchecklivedie.Count);
            tientrinh2.Text = $"0";
            MessageBox.Show($"Đã import thành công {listmailchecklivedie.Count} mail", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HttpRequest http = new HttpRequest();
            http.UserAgent = Http.ChromeUserAgent();
            string reponse = http.Get("https://domainr.com/lionpro.info").ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            xNet_Helper request = new xNet_Helper();
            string reponse = request.RequestGet($"https://domainr.com/lionpro.info");

        }

        private void từCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                listprx.Clear();
                string text = Clipboard.GetText(TextDataFormat.Text);
                listprx = text.Split(new string[]
                {
                    "\r\n",
                    "\r",
                    "\n"
                }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
                listprx = listprx.Distinct().ToList();
                tongproxy.Text = Convert.ToString(listprx.Count);
                MessageBox.Show($"Đã import thành công {listprx.Count} Proxy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
            }
        }

        private void từFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Title = "Add List Mail";
            opf.Filter = "Text |*.txt";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                listprx.Clear();
                listprx = new List<string>(File.ReadAllLines(opf.FileName).ToList<string>());
                listprx.RemoveAll(string.IsNullOrWhiteSpace);
                listprx = listprx.Distinct().ToList();
                opf.Dispose();
            }
            tongproxy.Text = Convert.ToString(listprx.Count);
            MessageBox.Show($"Đã import thành công {listprx.Count} Proxy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            testaa();
        }
    }
}
