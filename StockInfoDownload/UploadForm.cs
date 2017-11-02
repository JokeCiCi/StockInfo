using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SufeiUtil;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BLL;
using Model;
using System.Data.SqlClient;



namespace StockInfoDownload
{
    public partial class UploadForm : Form
    {

        StockMinInfoService _StockMinservice = new StockMinInfoService();
        StockInfoService _Stockservice = new StockInfoService();

        public UploadForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<StockInfo> stocklist=_Stockservice.GetModelList("");

            int y = stocklist.Count / 100 + 1;
            for (int num = 0; num < y;num++ )
            {
                int c = 100+num*100;
                if (c > stocklist.Count)
                {
                    c=stocklist.Count;
                }
                List<string> stocklist2 = new List<string>();
                HttpHelper http = new HttpHelper();
                HttpItem item = new HttpItem();
                item.URL = "http://api.money.126.net/data/feed/";
                
                for (int stockCount = num * 100; stockCount < c; stockCount++)
                {
                    string x = stocklist[stockCount].ToString();
                    switch (stocklist[stockCount].stockcode.Substring(0, 1))
                    {
                        //3-sz
                        //0-sz
                        //6-sh
                        default:
                            MessageBox.Show("1到5之外的数");
                            break;
                        case "0":
                            item.URL += "1" + stocklist[stockCount].stockcode + ",";
                            stocklist2.Add("1" + stocklist[stockCount].stockcode);
                            break;
                        case "3":
                            item.URL += "1" + stocklist[stockCount].stockcode + ",";
                            stocklist2.Add("1" + stocklist[stockCount].stockcode);
                            break;
                        case "6":
                            item.URL += "0" + stocklist[stockCount].stockcode + ",";
                            stocklist2.Add("0" + stocklist[stockCount].stockcode);
                            break;

                    }

                }
                item.URL += "money.api";

                item.Encoding = Encoding.UTF8;
                item.Method = "GET";
                item.Timeout = 100000;
                item.ReadWriteTimeout = 30000;//写入Post数据超时时间，可选项默认为30000

                HttpResult result = http.GetHtml(item);

                string html = result.Html;

                string statusCodeDescription = result.StatusDescription;
                //示例：
                //_ntes_quote_callback({"0601398":{"code": "0601398", "percent": 0.02314, "share": "1", "high": 6.26, "askvol3": 2000, "askvol2": 117612, "askvol5": 1075200, "askvol4": 1098800, "price": 6.19, "open": 6.05, "bid5": 6.13, "bid4": 6.14, "bid3": 6.15, "bid2": 6.16, "bid1": 6.17, "low": 6.02, "updown": 0.14, "type": "SH", "symbol": "601398", "status": 0, "ask4": 6.21, "bidvol3": 759900, "bidvol2": 762600, "bidvol1": 320900, "update": "2017/10/27 15:59:49", "bidvol5": 1270500, "bidvol4": 613200, "yestclose": 6.05, "askvol1": 66800, "ask5": 6.22, "volume": 456396456, "ask1": 6.18, "name": "\u5de5\u5546\u94f6\u884c", "ask3": 6.2, "ask2": 6.19, "arrow": "\u2191", "time": "2017/10/27 15:30:00", "turnover": 2808909770} });
                html = html.Replace("_ntes_quote_callback(", "");
                html = html.Replace(");", "");
                object b = JsonConvert.DeserializeObject(html);

                JObject ja = (JObject)JsonConvert.DeserializeObject(html);
                JObject jb = (JObject)ja["0601398"];
                JObject jb2 = (JObject)ja["1000002"];
                //StockMinInfo stock2 = JsonConvert.DeserializeObject<StockMinInfo>(jb.ToString());
                //StockMinInfo stock3 = JsonConvert.DeserializeObject<StockMinInfo>(ja["10000002"].ToString());
                foreach(string x in stocklist2){
                    StockMinInfo stock4 = JsonConvert.DeserializeObject<StockMinInfo>(ja[x].ToString());
                    int ID = _StockMinservice.Add(stock4);
                    if (ID > 0)
                    {
                    

                    }
                    else
                    {
                        MessageBox.Show(x.ToString());
                    }
                }
            }
            
            

        }
    }
}
