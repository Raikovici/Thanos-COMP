using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Security.Cryptography;
using System.Xml;
using System.IO;
using System.Collections.Generic;

namespace ThanosCOMP.AdminWindows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        static List<string> Accounts;
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void ShowAccountsButton_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new OnlineRetailEntities())
            {
                var accounts = from a in context.Accounts
                               select a;
                var listAccounts = accounts.ToList();
                var xmlDoc = new XmlDocument();
                xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null));
                var el = xmlDoc.CreateElement("Accounts");
                xmlDoc.AppendChild(el);
                
                for(int i = 0; i < accounts.Count(); i++)
                {
                    var child = xmlDoc.CreateElement("Account");

                    var attribute1 = xmlDoc.CreateAttribute("AccountId");
                    attribute1.Value = listAccounts[i].AccountID.ToString();

                    var attribute2 = xmlDoc.CreateAttribute("Password");
                    attribute2.Value = getHash(listAccounts[i].Password);

                    var attribute3 = xmlDoc.CreateAttribute("Username");
                    attribute3.Value = listAccounts[i].Username;

                    child.Attributes.Append(attribute1);
                    child.Attributes.Append(attribute3);
                    child.Attributes.Append(attribute2);

                    el.AppendChild(child);
                }
                xmlDoc.Save(getFilePath("XmlAccounts.xml"));
                MessageBox.Show("Xmldoc was created in " + getFilePath("XmlAccounts.xml"));

                Accounts = new List<string>(listAccounts.Count());
                parsingXMLDoc();

                DataTable table = new DataTable();
                DataColumn id = new DataColumn("Id");
                id.DataType = typeof(string);
                DataColumn user = new DataColumn("Username");
                id.DataType = typeof(string);
                DataColumn pass = new DataColumn("Password");
                id.DataType = typeof(string);

                table.Columns.Add(id);
                table.Columns.Add(user);
                table.Columns.Add(pass);
                for (int i = 0; i < Accounts.Count(); i++)
                {
                    if (Accounts[i] != string.Empty)
                    {
                        DataRow newRow = table.NewRow();
                        var my = Accounts[i].Split(' ');

                        newRow["Id"] = my[0];
                        newRow["Username"] = my[1];
                        newRow["Password"] = my[2];

                        table.Rows.Add(newRow);
                    }
                }
                ShowAccountsWindow S = new ShowAccountsWindow();
                S.AccountsTable.DataContext = table.DefaultView;
                S.Show();
            }
        }
        private static string getFilePath(string fileName)
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
        }
        private static void parsingXMLDoc()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(getFilePath("XmlAccounts.xml"));
            RecurseNodes(xmlDoc.DocumentElement);
        }

        public static void RecurseNodes(XmlNode node)
        {
            RecurseNodes(node, 0);
        }
        public static void RecurseNodes(XmlNode node, int level)
        {
            string elem = string.Empty;
            foreach (XmlAttribute attr in node.Attributes)
            {
                elem += attr.Value + " ";
            }
            foreach (XmlNode n in node.ChildNodes)
            {
                RecurseNodes(n, level + 1);
            }
            Accounts.Add(elem);
            elem = string.Empty;
        }
        private void ModifyAccountButton_Click(object sender, RoutedEventArgs e)
        {
            ModifyAccountWindow M = new ModifyAccountWindow();
            M.Show();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DeleteAccountWindow D = new DeleteAccountWindow();
            D.Show();
        }


        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            AddProductWindow A = new AddProductWindow();
            A.Show();
        }

        private void ModifyProductButton_Click(object sender, RoutedEventArgs e)
        {
            ModifyProductWindow M = new ModifyProductWindow();
            M.Show();
        }
        private void DeleteProductButton_Click(object sender, RoutedEventArgs e)
        {
            DeleteProductWindow D = new DeleteProductWindow();
            D.Show();
        }
        private void AddStockButton_Click(object sender, RoutedEventArgs e)
        {
            AddInStockWindow AP = new AddInStockWindow();
            AP.Show();
        }
        private void AddSupplierButton_Click(object sender, RoutedEventArgs e)
        {
            AddSupplierWindow AS = new AddSupplierWindow();
            AS.Show();
        }
        private void AddShipperButton_Click(object sender, RoutedEventArgs e)
        {
            AddShipperWindow A = new AddShipperWindow();
            A.Show();
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow M = new MainWindow();

            this.Close();
            M.Show();
        }
        private string getHash(string source)
        {
            var sourceBytes = Encoding.UTF8.GetBytes(source);
            var md5Hash = MD5.Create();
            var hashBytes = md5Hash.ComputeHash(sourceBytes);

            var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
            string S = hash.ToString();
            return S;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
