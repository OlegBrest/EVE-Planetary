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
        DataTable BPRTable = new DataTable();
        Dictionary<string, int> PriceKeys = new Dictionary<string, int>();
        int MaxThreads = 20;
        int PageSize = 150;
        struct ThreadStrInt
        {
            public string _str { get; set; }
            public int _int { get; set; }
        }

        public MainForm()
        {
            InitializeComponent();
            comboCalcSell.SelectedIndex = 0;
            comboCalcBuy.SelectedIndex = 1;
        }

        private DataTable CreatePriceTable()
        {
            DataTable dt = new DataTable("Materials");
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

        //todo need table or some to bluebrints
        private DataTable CreateBPRTable()
        {
            DataTable dt = new DataTable("BPRs");
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
                dt = CreatePriceTable();
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
                dt = CreatePriceTable();
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
            Thread PriceThreading = new Thread(UpdatePricesThrd);
            PriceThreading.Start();
        }

        private void UpdatePricesThrd()
        {
            int totalRows = MainPricesDT.Rows.Count;
            PriceKeys.Clear();
            for (int row = 0; row < totalRows; row++)
            {
                if (MainPricesDT.Rows[row]["ID"] != null)
                {
                    PriceKeys.Add(MainPricesDT.Rows[row]["ID"].ToString(), row);
                }
            }
            Invoke((MethodInvoker)delegate
            {
                ProgressBarPrice.Maximum = totalRows - 1;
                ProgressBarPrice.Minimum = 0;
                ProgressBarPrice.Value = 0;
                DGVPrices.DataSource = null;
                DGVPrices.Hide();
                DGVPrices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            });
            string matIDs = "";
            for (int row = 0; row < totalRows; row++)
            {
                if (MainPricesDT.Rows[row]["ID"] != null)
                {
                    matIDs += MainPricesDT.Rows[row]["ID"].ToString() + (((row % PageSize == 0) || (row == totalRows - 1)) ? "" : ",");
                    if (((row % PageSize == 0) || (row == totalRows - 1)) && (matIDs != ""))
                    {
                        string IDs = matIDs;
                        matIDs = "";
                        Thread nextQ = new Thread(new ParameterizedThreadStart(UpdateDt));
                        ThreadStrInt StrInt = new ThreadStrInt();
                        StrInt._str = IDs;
                        StrInt._int = row;
                        nextQ.Start(StrInt);
                    }
                }
            }
        }

        private void UpdateDt(object obj)
        {

            while (MaxThreads < 0)
            {
                Thread.Sleep(10);
            };
            MaxThreads--;
            ThreadStrInt StrInt = (ThreadStrInt)obj;
            string IDs;
            int rowsCnt;
            IDs = StrInt._str;
            rowsCnt = StrInt._int;
            XmlDocument doc1 = new XmlDocument();
            doc1.Load("https://api.evemarketer.com/ec/marketstat?typeid=" + IDs + "&regionlimit=10000002");

            XmlElement root = doc1.DocumentElement;
            XmlNodeList TypeNodes = root.SelectNodes("/exec_api/marketstat/type");

            Invoke((MethodInvoker)delegate
            {
                MainPricesDT.BeginLoadData();
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


                        MainPricesDT.Rows[curRow]["Buy(min)"] = Bmin;
                        MainPricesDT.Rows[curRow]["Buy(max)"] = Bmax;
                        MainPricesDT.Rows[curRow]["Buy(avg)"] = Bavg;
                        MainPricesDT.Rows[curRow]["Buy(median)"] = Bmed;
                        MainPricesDT.Rows[curRow]["Buy(self)"] = MainPricesDT.Rows[curRow]["Buy(self)"].ToString() == "" ? 0 : MainPricesDT.Rows[curRow]["Buy(self)"];

                        MainPricesDT.Rows[curRow]["Sell(min)"] = Smin;
                        MainPricesDT.Rows[curRow]["Sell(max)"] = Smax;
                        MainPricesDT.Rows[curRow]["Sell(avg)"] = Savg;
                        MainPricesDT.Rows[curRow]["Sell(median)"] = Smed;
                        MainPricesDT.Rows[curRow]["Sell(self)"] = MainPricesDT.Rows[curRow]["Sell(self)"].ToString() == "" ? 0 : MainPricesDT.Rows[curRow]["Sell(self)"];

                        /*Invoke((MethodInvoker)delegate
                        {*/
                        ProgressBarPrice.Value++;
                        if (ProgressBarPrice.Value == ProgressBarPrice.Maximum)
                        {
                            ProgressBarPrice.Value = 0;
                            ShowPriceDGV();
                        }
                        //});
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                MainPricesDT.EndLoadData();
            });
            MaxThreads++;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            //speedUP on datasource updating
            DGVPrices.Hide();
            DGVPrices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            MainPricesDT.BeginLoadData();
            if (File.Exists(@"Resources/elements.xml"))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(@"Resources/elements.xml");

                foreach (DataTable table in ds.Tables)
                {
                    if (table.TableName == "Materials")
                    {
                        MainPricesDT = CreatePriceTable();
                        MainPricesDT = table;
                        /*
                        MainPricesDT.Columns["Buy(min)"].DataType = typeof(double);
                        MainPricesDT.Columns["Buy(max)"].DataType = typeof(double);
                        MainPricesDT.Columns["Buy(avg)"].DataType = typeof(double);
                        MainPricesDT.Columns["Buy(median)"].DataType = typeof(double);
                        MainPricesDT.Columns["Buy(self)"].DataType = typeof(double);

                        MainPricesDT.Columns["Sell(min)"].DataType = typeof(double);
                        MainPricesDT.Columns["Sell(max)"].DataType = typeof(double);
                        MainPricesDT.Columns["Sell(avg)"].DataType = typeof(double);
                        MainPricesDT.Columns["Sell(median)"].DataType = typeof(double);
                        MainPricesDT.Columns["Sell(self)"].DataType = typeof(double);*/
                    }
                }
            }
            else
            {
                MainPricesDT = ReadTxt();
            }
            MainPricesDT.EndLoadData();
            ShowPriceDGV();
        }

        private void ClearEmpty_Click(object sender, EventArgs e)
        {
            DGVPrices.DataSource = null;
            int totalRows = MainPricesDT.Rows.Count - 1;
            ProgressBarPrice.Maximum = totalRows + 1;
            ProgressBarPrice.Minimum = 0;
            ProgressBarPrice.Value = 0;
            for (int i = totalRows; i >= 0; i--)
            {
                if ((MainPricesDT.Rows[i]["Buy(min)"].ToString() == "0") &&
                    (MainPricesDT.Rows[i]["Buy(max)"].ToString() == "0") &&
                (MainPricesDT.Rows[i]["Buy(avg)"].ToString() == "0") &&
                (MainPricesDT.Rows[i]["Buy(median)"].ToString() == "0") &&
                (MainPricesDT.Rows[i]["Sell(min)"].ToString() == "0") &&
                (MainPricesDT.Rows[i]["Sell(max)"].ToString() == "0") &&
                (MainPricesDT.Rows[i]["Sell(avg)"].ToString() == "0") &&
                (MainPricesDT.Rows[i]["Sell(median)"].ToString() == "0"))
                {
                    MainPricesDT.Rows.RemoveAt(i);
                }
                ProgressBarPrice.Value++;
            }
            ProgressBarPrice.Value = 0;
            ShowPriceDGV();
        }

        private void SaveBttn_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"Resources/elements.xml")) File.Delete(@"Resources/elements.xml");
            MainPricesDT.WriteXml(@"Resources/elements.xml",XmlWriteMode.WriteSchema);
        }

        private void ShowPriceDGV()
        {
            DGVPrices.DataSource = MainPricesDT;
            DGVPrices.Columns["ID"].DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" };
            DGVPrices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGVPrices.Show();
        }

        private void CalcBuySellFinder_Click(object sender, EventArgs e)
        {
            DGVCalcBuySell.DataSource = null;
            if (MainPricesDT.Select("[" + comboCalcSell.Text + "] < [" + comboCalcBuy.Text + "] AND" + "[" + comboCalcSell.Text + "]>0").Count()>0)
            {

                DataTable mostgoodprices = MainPricesDT.Select("[" + comboCalcSell.Text + "] < [" + comboCalcBuy.Text + "] AND" + "[" + comboCalcSell.Text + "]>0").CopyToDataTable();
                DataColumn colNew = new DataColumn();
                colNew.DataType = typeof(double);
                colNew.ColumnName = "Profit";
                mostgoodprices.Columns.Add(colNew);
                for (int i = 0; i < mostgoodprices.Rows.Count; i++)
                {
                    mostgoodprices.Rows[i]["Profit"] = (Convert.ToDouble(mostgoodprices.Rows[i][comboCalcBuy.Text].ToString()) - Convert.ToDouble(mostgoodprices.Rows[i][comboCalcSell.Text].ToString())) / Convert.ToDouble(mostgoodprices.Rows[i][comboCalcSell.Text]) * 100;
                }
                DGVCalcBuySell.DataSource = mostgoodprices;
            }
        }
    }
}
