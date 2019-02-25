using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace EVE_Planetary
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DGVPrices.DataSource = ReadXml();
        }

        private DataTable CreateTable()
        {
            DataTable dt = new DataTable("Matrials");
            DataColumn colID = new DataColumn("ID", typeof(Int32));
            DataColumn colName = new DataColumn("Name", typeof(String));

            DataColumn colBuyMin = new DataColumn("Buy(min)", typeof(String));
            DataColumn colBuyMedian = new DataColumn("Buy(median)", typeof(String));
            DataColumn colBuyAvg = new DataColumn("Buy(avg)", typeof(String));
            DataColumn colBuyMax = new DataColumn("Buy(max)", typeof(String));
            DataColumn colBuySelf = new DataColumn("Buy(self)", typeof(String));

            DataColumn colSellMin = new DataColumn("Sell(min)", typeof(String));
            DataColumn colSellMedian = new DataColumn("Sell(median)", typeof(String));
            DataColumn colSellAvg = new DataColumn("Sell(avg)", typeof(String));
            DataColumn colSellMax = new DataColumn("Sell(max)", typeof(String));
            DataColumn colSellSelf = new DataColumn("Sell(self)", typeof(String));

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


        private void UpdatePrices_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < DGVPrices.Rows.Count; row++)
            {
                if (DGVPrices.Rows[row].Cells["ID"].Value != null)
                {
                    XmlDocument doc1 = new XmlDocument();
                    doc1.Load("https://api.evemarketer.com/ec/marketstat?typeid=" + DGVPrices.Rows[row].Cells["ID"].Value.ToString() + "&regionlimit=10000002");
                    XmlElement root = doc1.DocumentElement;
                    XmlNodeList Bnodes = root.SelectNodes("/exec_api/marketstat/type/buy");
                    XmlNodeList Snodes = root.SelectNodes("/exec_api/marketstat/type/sell");

                    foreach (XmlNode node in Bnodes)
                    {
                        string Bmin = node["min"].InnerText;
                        string Bmax = node["max"].InnerText;
                        string Bavg = node["avg"].InnerText;
                        string Bmed = node["median"].InnerText;


                        DGVPrices.Rows[row].Cells["Buy(min)"].Value = Bmin;
                        DGVPrices.Rows[row].Cells["Buy(max)"].Value = Bmax;
                        DGVPrices.Rows[row].Cells["Buy(avg)"].Value = Bavg;
                        DGVPrices.Rows[row].Cells["Buy(median)"].Value = Bmed;
                    }

                    foreach (XmlNode node in Snodes)
                    {
                        string Smin = node["min"].InnerText;
                        string Smax = node["max"].InnerText;
                        string Savg = node["avg"].InnerText;
                        string Smed = node["median"].InnerText;


                        DGVPrices.Rows[row].Cells["Sell(min)"].Value = Smin;
                        DGVPrices.Rows[row].Cells["Sell(max)"].Value = Smax;
                        DGVPrices.Rows[row].Cells["Sell(avg)"].Value = Savg;
                        DGVPrices.Rows[row].Cells["Sell(median)"].Value = Smed;
                    }

                }
            }
        }
    }
}
