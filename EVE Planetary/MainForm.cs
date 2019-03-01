using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
using YamlDotNet.RepresentationModel;
using YamlDotNet;


namespace EVE_Planetary
{
    public partial class MainForm : Form
    {
        DataTable MainPricesDT = new DataTable();
        DataTable BPRTable = new DataTable();
        Dictionary<string, int> PriceKeys = new Dictionary<string, int>();
        int MaxThreads = 20;
        int PageSize = 150;
        XmlNode CurrentNode;
        XmlDocument xmlBPRDoc;
        TreeView CurrenttreeView;
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

        private DataTable CreateBPRTable()
        {
            DataTable dt = new DataTable("BPRs");
            DataColumn type = new DataColumn("Type", typeof(string));

            DataColumn colID = new DataColumn("ID_BPR", typeof(Int32));
            DataColumn colName = new DataColumn("Name_BPR", typeof(String));

            DataColumn outID = new DataColumn("ID_out", typeof(Int32));
            DataColumn outName = new DataColumn("Name_out", typeof(String));
            DataColumn outCount = new DataColumn("Count_out", typeof(double));

            DataColumn inID = new DataColumn("ID_in", typeof(Int32));
            DataColumn inName = new DataColumn("Name_in", typeof(String));
            DataColumn inCount = new DataColumn("Count_in", typeof(double));

            dt.Columns.Add(type);
            dt.Columns.Add(colID);
            dt.Columns.Add(colName);

            dt.Columns.Add(outID);
            dt.Columns.Add(outName);
            dt.Columns.Add(outCount);

            dt.Columns.Add(inID);
            dt.Columns.Add(inName);
            dt.Columns.Add(inCount);


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
                    }
                }
            }
            else
            {
                MainPricesDT = ReadTxt();
            }
            MainPricesDT.EndLoadData();
            ShowPriceDGV();
            LoadBPRXML();
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
                (MainPricesDT.Rows[i]["Sell(median)"].ToString() == "0") &&
                (!MainPricesDT.Rows[i]["Name"].ToString().Contains("Blueprint")))
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
            MainPricesDT.WriteXml(@"Resources/elements.xml", XmlWriteMode.WriteSchema);
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
            if (MainPricesDT.Select("[" + comboCalcSell.Text + "] < [" + comboCalcBuy.Text + "] AND" + "[" + comboCalcSell.Text + "]>0").Count() > 0)
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
                DGVCalcBuySell.Columns["ID"].DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" };
                DGVCalcBuySell.Columns["Profit"].DefaultCellStyle = new DataGridViewCellStyle { Format = "N5" };
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BPRTable = CreateBPRTable();
            //DGVFormManuf.DataSource = BPRTable;
        }

        private void ButtonAddEditManuf_Click(object sender, EventArgs e)
        {
            if (CurrentNode != null)
            {
                #region Adding
                if ((CurrentNode.Name == "B") || (CurrentNode.Name == "P") || (CurrentNode.Name == "R"))
                {
                    XmlElement elm = CurrentNode.OwnerDocument.CreateElement("BPR");
                    elm.SetAttribute("Name", textBoxFormManufBPName.Text);
                    AddSingleNode(CurrentNode.InsertAfter(elm, CurrentNode.LastChild), CurrenttreeView.SelectedNode);
                }
                if ((textBoxFormManufOutName.Text != "") && (CurrentNode.Name == "BPR"))
                {
                    XmlElement elm = CurrentNode.OwnerDocument.CreateElement("Out");
                    elm.SetAttribute("Name", textBoxFormManufOutName.Text);
                    elm.SetAttribute("id", textBoxFormManufOutID.Text);
                    elm.SetAttribute("count", textBoxFormManufOutCount.Text);
                    AddSingleNode(CurrentNode.InsertAfter(elm, CurrentNode.LastChild), CurrenttreeView.SelectedNode);
                }
                if ((textBoxFormManufOutName.Text != "") && (CurrentNode.Name == "Out"))
                {
                    XmlElement elm = CurrentNode.OwnerDocument.CreateElement("In");
                    elm.SetAttribute("Name", textBoxFormManufInputName.Text);
                    elm.SetAttribute("id", textBoxFormManufInputID.Text);
                    elm.SetAttribute("count", textBoxFormManufInputCount.Text);
                    elm.InnerText = textBoxFormManufInputCount.Text;
                    AddSingleNode(CurrentNode.InsertAfter(elm, CurrentNode.LastChild), CurrenttreeView.SelectedNode);
                }
                #endregion

                #region Editing
                if ((textBoxFormManufInputName.Text != "") && (CurrentNode.Name == "In"))
                {
                    CurrentNode.Attributes["Name"].Value = textBoxFormManufInputName.Text;
                    CurrentNode.Attributes["id"].Value = textBoxFormManufInputID.Text;
                    CurrentNode.Attributes["count"].Value = textBoxFormManufInputCount.Text;
                    CurrentNode.InnerText = textBoxFormManufInputCount.Text;
                    CurrenttreeView.SelectedNode.Text = textBoxFormManufInputName.Text + (textBoxFormManufInputCount.Text == "" ? "" : (" | " + textBoxFormManufInputCount.Text));
                }
                else if ((textBoxFormManufOutName.Text != "") && (CurrentNode.Name == "Out"))
                {
                    CurrentNode.Attributes["Name"].Value = textBoxFormManufOutName.Text;
                    CurrentNode.Attributes["id"].Value = textBoxFormManufOutID.Text;
                    CurrentNode.Attributes["count"].Value = textBoxFormManufOutCount.Text;
                    CurrenttreeView.SelectedNode.Text = textBoxFormManufOutName.Text + (textBoxFormManufOutCount.Text == "" ? "" : (" | " + textBoxFormManufOutCount.Text));
                }
                else if ((textBoxFormManufBPName.Text != "") && (CurrentNode.Name == "BPR"))
                {
                    CurrentNode.Attributes["Name"].Value = textBoxFormManufBPName.Text;
                    CurrenttreeView.SelectedNode.Text = textBoxFormManufBPName.Text;
                }
                #endregion

                if (File.Exists(@"Resources/BPRs.xml")) File.Delete(@"Resources/BPRs.xml");
                CurrentNode.OwnerDocument.Save(@"Resources/BPRs.xml");
                //LoadBPRXML();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadBPRXML();
        }

        private void LoadBPRXML()
        {
            if (File.Exists(@"Resources/BPRs.xml"))
            {
                xmlBPRDoc = new XmlDocument();
                xmlBPRDoc.Load(@"Resources/BPRs.xml");
                treeViewFormManuf.Nodes.Clear();
                treeViewFormManuf.Nodes.Add(new TreeNode("BluePrints"));
                TreeNode rootNode = new TreeNode();
                rootNode = treeViewFormManuf.Nodes[0];
                AddNode(xmlBPRDoc.DocumentElement.SelectSingleNode("/BPRs/B"), rootNode);

                treeViewFormPlanet.Nodes.Clear();
                treeViewFormPlanet.Nodes.Add(new TreeNode("Schematics"));
                rootNode = treeViewFormPlanet.Nodes[0];
                AddNode(xmlBPRDoc.DocumentElement.SelectSingleNode("/BPRs/P"), rootNode);

                treeViewFormReact.Nodes.Clear();
                treeViewFormReact.Nodes.Add(new TreeNode("Reactions"));
                rootNode = treeViewFormReact.Nodes[0];
                AddNode(xmlBPRDoc.DocumentElement.SelectSingleNode("/BPRs/R"), rootNode);
            }
        }

        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i;
            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                int nodsCount = nodeList.Count;
                for (i = 0; i < nodsCount; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    XmlAttributeCollection attributeCollection = xNode.Attributes;
                    TreeNode treeNode = new TreeNode();
                    treeNode.Name = xNode.Name;
                    if (attributeCollection != null)
                    {
                        //проверяем наличие атрибута Name
                        if (attributeCollection["Name"] != null)
                        {
                            treeNode.Text = attributeCollection["Name"].Value.ToString();
                        }
                        else
                        {
                            treeNode.Text = xNode.Name;
                        }
                        //проверяем наличие атрибута Name
                        if (attributeCollection["count"] != null)
                        {
                            treeNode.Text += (" | " + attributeCollection["count"].Value.ToString());
                        }
                    }
                    if (xNode.Name != "#text")
                    {
                        treeNode.Tag = xNode;
                        int intNode = inTreeNode.Nodes.Add(treeNode);
                        tNode = inTreeNode.Nodes[i];
                        inTreeNode.Nodes[intNode].Parent.Tag = xNode.ParentNode;
                        AddNode(xNode, tNode);
                    }

                }
            }
            else
            {
                inTreeNode.Tag = inXmlNode;
            }
        }

        private void AddSingleNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlAttributeCollection attributeCollection = inXmlNode.Attributes;
            TreeNode treeNode = new TreeNode();
            treeNode.Name = inXmlNode.Name;
            if (attributeCollection != null)
            {
                //проверяем наличие атрибута Name
                if (attributeCollection["Name"] != null)
                {
                    treeNode.Text = attributeCollection["Name"].Value.ToString();
                }
                else
                {
                    treeNode.Text = inXmlNode.Name;
                }
                //проверяем наличие атрибута Name
                if (attributeCollection["count"] != null)
                {
                    treeNode.Text += (" | " + attributeCollection["count"].Value.ToString());
                }
            }
            treeNode.Tag = inXmlNode;
            inTreeNode.Nodes.Add(treeNode);
        }

        private DataTable ReadXmlBPR()
        {
            DataTable dt = null;
            try
            {
                //загружаем xml файл
                XDocument xDoc = XDocument.Load(@"Resources/BPRs.xml");
                //создаём таблицу
                dt = CreatePriceTable();
                DataRow newRow = null;
                //получаем все узлы в xml файле
                foreach (XElement elm in xDoc.Descendants("BPRs"))
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

        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Find Node By Name
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(@"Resources/BPRs.xml");
            CurrentNode = (XmlNode)(e.Node.Tag);
            if (CurrentNode != null)
            {
                XmlAttributeCollection atrCol;
                atrCol = CurrentNode.Attributes;
                if ((CurrentNode.Name == "B") || (CurrentNode.Name == "P") || (CurrentNode.Name == "R"))
                {
                    textBoxFormManufBPName.Text = "";
                    textBoxFormManufOutName.Text = "";
                    textBoxFormManufOutID.Text = "";
                    textBoxFormManufOutCount.Text = "";
                    textBoxFormManufInputName.Text = "";
                    textBoxFormManufInputID.Text = "";
                    textBoxFormManufInputCount.Text = "";
                }
                if (CurrentNode.Name == "BPR")
                {
                    textBoxFormManufBPName.Text = CurrentNode.Attributes["Name"].Value.ToString();

                    textBoxFormManufOutName.Text = "";
                    textBoxFormManufOutID.Text = "";
                    textBoxFormManufOutCount.Text = "";

                    textBoxFormManufInputName.Text = "";
                    textBoxFormManufInputID.Text = "";
                    textBoxFormManufInputCount.Text = "";
                }
                if (CurrentNode.Name == "Out")
                {
                    textBoxFormManufBPName.Text = CurrentNode.ParentNode.Attributes["Name"].Value.ToString();

                    textBoxFormManufOutName.Text = CurrentNode.Attributes["Name"].Value.ToString();
                    textBoxFormManufOutID.Text = CurrentNode.Attributes["id"].Value.ToString();
                    textBoxFormManufOutCount.Text = CurrentNode.Attributes["count"].Value.ToString();

                    textBoxFormManufInputName.Text = "";
                    textBoxFormManufInputID.Text = "";
                    textBoxFormManufInputCount.Text = "";
                }
                if (CurrentNode.Name == "In")
                {
                    textBoxFormManufBPName.Text = CurrentNode.ParentNode.ParentNode.Attributes["Name"].Value.ToString();

                    textBoxFormManufOutName.Text = CurrentNode.ParentNode.Attributes["Name"].Value.ToString();
                    textBoxFormManufOutID.Text = CurrentNode.ParentNode.Attributes["id"].Value.ToString();
                    textBoxFormManufOutCount.Text = CurrentNode.ParentNode.Attributes["count"].Value.ToString();

                    textBoxFormManufInputName.Text = CurrentNode.Attributes["Name"].Value.ToString();
                    textBoxFormManufInputID.Text = CurrentNode.Attributes["id"].Value.ToString();
                    textBoxFormManufInputCount.Text = CurrentNode.Attributes["count"].Value.ToString();
                }
            }
        }

        private void textBox_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox.AutoCompleteCustomSource.Count == 0)
            {
                DataRow[] dataRows = MainPricesDT.Select("Name <> ''", "Name");
                AutoCompleteStringCollection customsource = new AutoCompleteStringCollection();
                foreach (DataRow dr in dataRows)
                {
                    customsource.Add(dr["Name"].ToString());
                }
                textBox.AutoCompleteCustomSource = customsource;
            }
        }

        private void textBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            //textBox.AutoCompleteCustomSource.Clear();
            DataRow[] dataRows = MainPricesDT.Select("Name = '" + textBox.Text.Replace("'", "''") + "'", "Name");
            if (dataRows.Count() > 0)
                (this.Controls.Find(textBox.Tag.ToString(), true)[0] as TextBox).Text = dataRows[0]["Id"].ToString();
            else
                (this.Controls.Find(textBox.Tag.ToString(), true)[0] as TextBox).Text = "";
        }

        private void textBoxID_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            //textBox.AutoCompleteCustomSource.Clear();
            DataRow[] dataRows = MainPricesDT.Select("id = '" + textBox.Text.Replace("'", "''") + "'", "id");
            if (dataRows.Count() > 0)
                (this.Controls.Find(textBox.Tag.ToString(), true)[0] as TextBox).Text = dataRows[0]["Name"].ToString();
            else
                (this.Controls.Find(textBox.Tag.ToString(), true)[0] as TextBox).Text = "";
        }

        private void ButtonRemoveManuf_Click(object sender, EventArgs e)
        {
            CurrentNode.ParentNode.RemoveChild(CurrentNode);
            if (File.Exists(@"Resources/BPRs.xml")) File.Delete(@"Resources/BPRs.xml");
            CurrentNode.OwnerDocument.Save(@"Resources/BPRs.xml");
            CurrenttreeView.SelectedNode.Remove();
            //    LoadBPRXML();
        }

        private void treeView_MouseClick(object sender, MouseEventArgs e)
        {
            CurrenttreeView = (sender as TreeView);
        }

        private void yamlReader()
        {


            YamlStream stream = new YamlStream();
            using (var reader = new StreamReader(@"Resources/typeIDs.yaml"))
            {
                stream.Load(reader);
            }
            YamlDocument yaDoc = stream.Documents[0];
            YamlMappingNode yamm = (YamlMappingNode)(yaDoc.RootNode);
            foreach (KeyValuePair<YamlNode, YamlNode> KVP in yamm.Children)
            {
                int id = Convert.ToInt32(((YamlScalarNode)KVP.Key).Value);
                string name = ((YamlScalarNode)((YamlMappingNode)((YamlMappingNode)KVP.Value).Children["name"]).Children["ru"]).Value;
                MessageBox.Show(name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yamlReader();
        }
    }
}
