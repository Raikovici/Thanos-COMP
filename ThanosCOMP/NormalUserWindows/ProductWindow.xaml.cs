using System.Windows;
using System.Windows.Input;
using ThanosCOMP.NormalUserWindows.MVVM.View;
using ThanosCOMP.NormalUserWindows.MVVM.ViewModel;
using System.Linq;
using System.Windows.Media.Imaging;
using System.IO;
using System.Windows.Media;
using System;
using System.Collections.Generic;

namespace ThanosCOMP.NormalUserWindows
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        static int categId;
        static string supplierInfo;
        static string shippingInfo;
        static List<int> ids;
        static int idLaptop;
        static int idPc;
        static int idKeyboard;
        static int idMonitor;
        static int idMouse;
        static int idHdd;
        static int idPcComp;

        static int idProduct;
        public ProductWindow()
        {
            InitializeComponent();
            ids = new List<int>();
            idLaptop = LaptopsView.laptopButtonId;
            ids.Add(idLaptop);
            idPc = PCView.pcButtonId;
            ids.Add(idPc);
            idKeyboard = KeyboardsView.keyboardButtonId;
            ids.Add(idKeyboard);
            idMonitor = MonitorsView.monitorButtonId;
            ids.Add(idMonitor);
            idMouse = MiceView.mouseButtonId;
            ids.Add(idMouse);
            idHdd = ExternalMemoryView.hddButtonId;
            ids.Add(idHdd);
            idPcComp = PCComponentsView.pcCompButtonId;
            ids.Add(idPcComp);
            categId = MainViewModel.categoryId;
            var idProdChosen = 0;
            foreach(var c in ids)
            {
                if(c != 0)
                {
                    idProdChosen = c;
                }
            }

            using (var context = new OnlineRetailEntities())
            {
                var prods = from p in context.Products
                            where p.CategoryID.Equals(categId)
                            select p;
                
                var idProdBd = 0;
                if(idProdChosen < 1)
                {
                    MessageBox.Show("Invalid id");
                }
                idProdBd = prods.ToList()[idProdChosen - 1].ProductID;
                if(idProdBd != 0)
                {
                    var product = (from l in context.Products
                                   where l.ProductID.Equals(idProdBd)
                                   select l).First();
                    idProduct = product.ProductID;

                    var categName = (from c in context.Categories
                                     where c.CategoryID.Equals(categId)
                                     select c.CategoryName).First();
                    ProductAndCategoryName.Text = product.ProductName + "\n" + categName;

                    var supplier = (from s in context.Suppliers 
                                    join p in context.Products on s.SupplierID equals p.SupplierID
                                    where s.SupplierID.Equals(product.SupplierID)
                                    select s).First();
                    SupplierName.Text = supplier.SupplierName.ToString();

                    var shipper = (from s in context.Shippings
                                   join p in context.Products on s.ShippingID equals p.ShippingID
                                   where s.ShippingID.Equals(product.ShippingID)
                                   select s).First();
                    ShipperName.Text = shipper.ShippingName.ToString();

                    PriceTag.Text = product.ProductPrice.ToString();
                    if(product.UnitsInStock < 5)
                    {
                        StockStatus.Text = "Limited stock";
                    }
                    else if (product.UnitsInStock == 0)
                    {
                        StockStatus.Text = "No available products";
                    }
                    else
                    {
                        StockStatus.Text = "In stock";
                    }

                    ProductDetails.Text = product.Description.ToString();
                    supplierInfo = supplier.SupplierName + ": " + supplier.SupplierAddress +
                        "\nHome page: " + supplier.SupplierHomePage + " Telephone: " + supplier.SupplierTelephone;
                    shippingInfo = shipper.ShippingName + ": " + shipper.ShippingHomePage +
                        "\nHome Page: " + shipper.ShippingHomePage + " Telephone: " + shipper.ShippingTelephone;

                    suppButtonToolTip.Text = supplierInfo;
                    shippButtonToolTip.Text = shippingInfo;
                    BitmapImage biImg = new BitmapImage();
                    MemoryStream ms = new MemoryStream(product.Photo);
                    biImg.BeginInit();
                    biImg.StreamSource = ms;
                    biImg.EndInit();

                    ImageSource imgSrc = biImg as ImageSource;
                    ProductImage.Source = imgSrc;
                }
            }
            
        }

        private void AddToShoppingCartButton_Click(object sender, RoutedEventArgs e)
        {
            //daca shopping cart table nu are un obiect cu userid deja existent => doar adaugam shopping cart details
            //altfel => creem shopping cart si dupa adaugam shopping cart details
            using( var context = new OnlineRetailEntities())
            {

                if (!(from sc in context.ShoppingCarts
                     where sc.UserID.Equals(UserDetails.Current_User)
                     select sc).Any()) //nu am gasit shopping cart, creem
                {
                    var NewShoppingCart = new ShoppingCart()
                    {
                        UserID = UserDetails.Current_User
                    };
                    context.ShoppingCarts.Add(NewShoppingCart);
                    context.SaveChanges();

                }
                var shopping_cart = (from sc in context.ShoppingCarts
                                     where sc.UserID.Equals(UserDetails.Current_User)
                                     select sc).First();

                //adaugam in shopping cart oricum


                var NewShoppingCartDetails = new ShoppingCartDetail() //Quanity = 1 default
                {
                    ShoppingCartID = shopping_cart.ShoppingCartID,
                    ProductID = idProduct,
                    Quantity = 1
                };
                context.ShoppingCartDetails.Add(NewShoppingCartDetails);
                context.SaveChanges();

                MessageBox.Show("The product was added in your shopping cart!");

            }

        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            ids.Clear();
            idHdd = 0;
            idLaptop = 0;
            idKeyboard = 0;
            idMonitor = 0;
            idMouse = 0;
            idPcComp = 0;
            idPc = 0;
            supplierInfo = string.Empty;
            shippingInfo = string.Empty;
            categId = 0;
            ShipperName.Clear();
            SupplierName.Clear();
            PriceTag.Clear();
            ProductDetails.Clear();
            ProductAndCategoryName.Clear();
            StockStatus.Clear();
            this.Close();
        }

    }
}
