using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using HtmlAgilityPack;

namespace ShadowSocksPassWordSync
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnLoadJsonFile_Click(object sender, EventArgs e)
        {
            ofdFileOpen.ShowDialog(this);
            if (!String.IsNullOrWhiteSpace(ofdFileOpen.FileName))
            {
                this.txtJsonFileName.Text = ofdFileOpen.FileName;
            }
        }
        private void btnSync_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtJsonFileName.Text))
            {
                if (File.Exists(txtJsonFileName.Text))
                {
                    SyncSSPassWord();
                }
                else
                {
                    MessageBox.Show("请选择一个存在的JSON文件");
                }
            }
            else
            {
                MessageBox.Show("JSON文件必须选择");
            }
        }
        public void SyncSSPassWord()
        {
            try
            {
                string Result = NetHelper.GetByUrl("http://www.ishadowsocks.com/");
                if (!String.IsNullOrWhiteSpace(Result))
                {
                    string jsonStr = File.ReadAllText(this.txtJsonFileName.Text);
                    var jsonDict = JsonHelper.JsonToDictionary(jsonStr);
                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(Result);
                    List<HtmlNode> nodes = doc.DocumentNode.SelectNodes(@"//div[@class='col-lg-4 text-center']").ToList();
                    List<SSConfig> configList = new List<SSConfig>();
                    foreach (HtmlNode node in nodes)
                    {
                        List<String> valueList = node.InnerText.Replace("\n", "|").Replace(" ", "").Split('|').ToList();
                        valueList.RemoveAll(p => p == "");
                        SSConfig config = new SSConfig();
                        foreach (String str in valueList)
                        {
                            if (str.Contains("服务器"))
                            {
                                config.server = str.Split(':')[1];
                            }
                            if (str.Contains("端口"))
                            {
                                config.server_port = str.Split(':')[1];
                            }
                            if (str.Contains("密码:"))
                            {
                                config.password = str.Split(':')[1];
                            }
                            if (str.Contains("加密"))
                            {
                                config.method = str.Split(':')[1];
                            }
                        }
                        config.remarks = config.server;
                        if (config.server != null)
                        {
                            configList.Add(config);
                        }
                    }
                    jsonDict["configs"] = configList;
                    File.WriteAllText(txtJsonFileName.Text, JsonHelper.DictionaryToJson(jsonDict));
                    MessageBox.Show("同步成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("同步失败，原因:" + ex.Message);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
    public class SSConfig
    {
        public string server { get; set; }
        public string server_port { get; set; }
        public string password { get; set; }
        public string method { get; set; }
        public string remarks { get; set; }
    }
}
