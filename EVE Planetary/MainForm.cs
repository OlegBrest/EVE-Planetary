using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace EVE_Planetary
{
    public partial class MainForm : Form
    {
        DataTable MainPricesDT = new DataTable();
        Dictionary<string, int> PriceKeys = new Dictionary<string, int>();
        struct ThreadStrInt
        {
            public string _str { get; set; }
            public int _int { get; set; }
        }
        public MainForm()
        {
            InitializeComponent();
            //speedUP on datasource updating
            DGVPrices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            MainPricesDT.BeginLoadData();
            MainPricesDT = ReadTxt();
            MainPricesDT.AcceptChanges();
            MainPricesDT.EndLoadData();
            DGVPrices.DataSource = MainPricesDT;
            DGVPrices.Columns["ID"].DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" };
            DGVPrices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private DataTable CreateTable()
        {
            DataTable dt = new DataTable("Matrials");
            DataColumn colID = new DataColumn("ID", typeof(Int32));
            DataColumn colName = new DataColumn("Name", typeof(String));

            DataColumn colBuyMin = new DataColumn("Buy(min)", typeof(double));
            DataColumn colBuyMedian = new DataColumn("Buy(median)", typeof(double));
            DataColumn colBuyAvg = new DataColumn("Buy(avg)", typeof(double));
            DataColumn colBuyMax = new DataColumn("Buy(max)", typeof(double));
            DataColumn colBuySelf = new DataColumn("Buy(self)", typeof(double));

            DataColumn colSellMin = new DataColumn("Sell(min)", typeof(double));
            DataColumn colSellMedian = new DataColumn("Sell(median)", typeof(double));
            DataColumn colSellAvg = new DataColumn("Sell(avg)", typeof(double));
            DataColumn colSellMax = new DataColumn("Sell(max)", typeof(double));
            DataColumn colSellSelf = new DataColumn("Sell(self)", typeof(double));

            dt.Columns.Add(colID);
            dt.Columns.Add(colName);

            dt.Columns.Add(colBuyMin);
            dt.Columns.Add(colBuyMedian);
            dt.Columns.Add(colBuyAvg);
            dt.Columns.Add(colBuyMax);
            dt.Columns.Add(colBuySelf);

            dt.Columns.Add(colSellMin);
            dt.Columns.Add(colSellMedian);
            dt.Columns.Add(colSellAvg);
            dt.Columns.Add(colSellMax);
            dt.Columns.Add(colSellSelf);

            return dt;
        }

        private DataTable ReadXml()
        {
            DataTable dt = null;
            try
            {
                //загружаем xml файл
                XDocument xDoc = XDocument.Load(@"Resources/elements.xml");
                //создаём таблицу
                dt = CreateTable();
                DataRow newRow = null;
                //получаем все узлы в xml файле
                foreach (XElement elm in xDoc.Descendants("material"))
                {
                    //создаём новую запись
                    newRow = dt.NewRow();
                    //проверяем наличие атрибутов (если требуется)
                    if (elm.HasAttributes)
                    {
                        //проверяем наличие атрибута id
                        if (elm.Attribute("id") != null)
                        {
                            //получаем значение атрибута
                            newRow["ID"] = int.Parse(elm.Attribute("id").Value);
                        }
                    }
                    #region проверяем наличие xml элементов
                    if (elm.Element("name") != null)
                    {
                        newRow["Name"] = elm.Element("name").Value;
                    }

                    if (elm.Element("BuyMin") != null)
                    {
                        newRow["Buy(min)"] = elm.Element("BuyMin").Value;
                    }
                    if (elm.Element("BuyMed") != null)
                    {
                        newRow["Buy(median)"] = elm.Element("BuyMed").Value;
                    }
                    if (elm.Element("BuyAvg") != null)
                    {
                        newRow["Buy(avg)"] = elm.Element("BuyAvg").Value;
                    }
                    if (elm.Element("BuyMax") != null)
                    {
                        newRow["Buy(max)"] = elm.Element("BuyMax").Value;
                    }
                    if (elm.Element("BuySelf") != null)
                    {
                        newRow["Buy(self)"] = elm.Element("BuySelf").Value;
                    }

                    if (elm.Element("SellMin") != null)
                    {
                        newRow["Sell(min)"] = elm.Element("SellMin").Value;
                    }
                    if (elm.Element("SellMed") != null)
                    {
                        newRow["Sell(median)"] = elm.Element("SellMed").Value;
                    }
                    if (elm.Element("SellAvg") != null)
                    {
                        newRow["Sell(avg)"] = elm.Element("SellAvg").Value;
                    }
                    if (elm.Element("SellMax") != null)
                    {
                        newRow["Sell(max)"] = elm.Element("SellMax").Value;
                    }
                    if (elm.Element("SellSelf") != null)
                    {
                        newRow["Sell(self)"] = elm.Element("SellSelf").Value;
                    }
                    #endregion

                    //добавляем новую запись в таблицу
                    dt.Rows.Add(newRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        private DataTable ReadTxt()
        {
            DataTable dt = null;
            try
            {
                dt = CreateTable();
                StreamReader sr = new StreamReader(@"Resources/typeids.txt");
                string line;
                DataRow newRow = null;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    newRow = dt.NewRow();
                    newRow["ID"] = line.Split(',')[0];
                    newRow["Name"] = line.Split(',')[1];
                    dt.Rows.Add(newRow);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        private void UpdatePrices_Click(object sender, EventArgs e)
        {
            /*Thread PriceThreading = new Thread(UpdatePricesThrd);
            PriceThreading.Start();*/
            //UpdatePricesThrd();
            int totalRows = MainPricesDT.Rows.Count;
            for (int row = 0; row < totalRows; row++)
            {
                if (MainPricesDT.Rows[row]["ID"] != null)
                {
                    PriceKeys.Add(MainPricesDT.Rows[row]["ID"].ToString(), row);
                }
            }
            Invoke((MethodInvoker)delegate
            {
                ProgressBarPrice.Maximum = totalRows;
                ProgressBarPrice.Minimum = 0;
                DGVPrices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            });
            string matIDs = "";
            int rowsCnt = 0;
            for (int row = 0; row < totalRows; row++)
            {
                if (MainPricesDT.Rows[row]["ID"] != null)
                {
                    rowsCnt++;
                    matIDs += MainPricesDT.Rows[row]["ID"].ToString() + (((rowsCnt % 100 == 0) || (rowsCnt == totalRows - 1)) ? "" : ",");
                    if (((rowsCnt % 100 == 0) || (rowsCnt == totalRows - 1)) && (matIDs != ""))
                    {
                        string IDs = matIDs;
                        matIDs = "";
                        Thread nextQ = new Thread(new ParameterizedThreadStart(UpdateDt));
                        ThreadStrInt StrInt = new ThreadStrInt();
                        StrInt._str = IDs;
                        StrInt._int = rowsCnt;
                        nextQ.Start(StrInt);
                    }
                }
            }
            Invoke((MethodInvoker)delegate
            {
                DGVPrices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            });
        }

        private void UpdatePricesThrd()
        {
            int totalRows = MainPricesDT.Rows.Count;
            for (int row = 0; row < totalRows; row++)
            {
                if (MainPricesDT.Rows[row]["ID"] != null)
                {
                    PriceKeys.Add(MainPricesDT.Rows[row]["ID"].ToString(), row);
                }
            }
            Invoke((MethodInvoker)delegate
            {
                ProgressBarPrice.Maximum = totalRows;
                ProgressBarPrice.Minimum = 0;
            DGVPrices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            });
            string matIDs = "";
            int rowsCnt = 0;
            for (int row = 0; row < totalRows; row++)
            {
                if (MainPricesDT.Rows[row]["ID"] != null)
                {
                    rowsCnt++;
                    matIDs += MainPricesDT.Rows[row]["ID"].ToString() + (((rowsCnt % 100 == 0) || (rowsCnt == totalRows - 1)) ? "" : ",");
                    if (((rowsCnt % 100 == 0) || (rowsCnt == totalRows - 1)) && (matIDs != ""))
                    {
                        string IDs = matIDs;
                        matIDs = "";
                        Thread nextQ = new Thread(new ParameterizedThreadStart(UpdateDt));
                        ThreadStrInt StrInt = new ThreadStrInt();
                        StrInt._str = IDs;
                        StrInt._int = rowsCnt;
                        nextQ.Start(StrInt);
                    }

                }
            }
            Invoke((MethodInvoker)delegate
            {
                DGVPrices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            });
        }

        private void UpdateDt(object obj)
        {
            Thread.Sleep(5);
            ThreadStrInt StrInt = (ThreadStrInt)obj;
            string IDs;
            int rowsCnt;
            IDs = StrInt._str;
            rowsCnt = StrInt._int;
            XmlDocument doc1 = new XmlDocument();
            doc1.Load("https://api.evemarketer.com/ec/marketstat?typeid=" + IDs + "&regionlimit=10000002");

            XmlElement root = doc1.DocumentElement;
            XmlNodeList TypeNodes = root.SelectNodes("/exec_api/marketstat/type");


            foreach (XmlNode Tnode in TypeNodes)
            {
                try
                {
                    int curRow = 0;
                    PriceKeys.TryGetValue(Tnode.Attributes["id"].Value, out curRow);
                    XmlNode Bnodes = Tnode.SelectSingleNode("buy");
                    XmlNode Snodes = Tnode.SelectSingleNode("sell");

                    double Bmin = Convert.ToDouble(Bnodes["min"].InnerText, CultureInfo.GetCultureInfo("en-US").NumberFormat);
                    double Bmax = Convert.ToDouble(Bnodes["max"].InnerText, CultureInfo.GetCultureInfo("en-US").NumberFormat);
                    double Bavg = Convert.ToDouble(Bnodes["avg"].InnerText, CultureInfo.GetCultureInfo("en-US").NumberFormat);
                    double Bmed = Convert.ToDouble(Bnodes["median"].InnerText, CultureInfo.GetCultureInfo("en-US").NumberFormat);

                    double Smin = Convert.ToDouble(Snodes["min"].InnerText, CultureInfo.GetCultureInfo("en-US").NumberFormat);
                    double Smax = Convert.ToDouble(Snodes["max"].InnerText, CultureInfo.GetCultureInfo("en-US").NumberFormat);
                    double Savg = Convert.ToDouble(Snodes["avg"].InnerText, CultureInfo.GetCultureInfo("en-US").NumberFormat);
                    double Smed = Convert.ToDouble(Snodes["median"].InnerText, CultureInfo.GetCultureInfo("en-US").NumberFormat);

                    Invoke((MethodInvoker)delegate
                    {
                       // MainPricesDT.BeginLoadData();
                        MainPricesDT.Rows[curRow]["Buy(min)"] = Bmin;
                        MainPricesDT.Rows[curRow]["Buy(max)"] = Bmax;
                        MainPricesDT.Rows[curRow]["Buy(avg)"] = Bavg;
                        MainPricesDT.Rows[curRow]["Buy(median)"] = Bmed;

                        MainPricesDT.Rows[curRow]["Sell(min)"] = Smin;
                        MainPricesDT.Rows[curRow]["Sell(max)"] = Smax;
                        MainPricesDT.Rows[curRow]["Sell(avg)"] = Savg;
                        MainPricesDT.Rows[curRow]["Sell(median)"] = Smed;
                     //   MainPricesDT.EndLoadData();

                        ProgressBarPrice.Value++;
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
