using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ICETaskKFC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //New edits from this point on
        
         private void btnAddProduct_Click(object sender, RoutedEventArgs e) //Insert Button to add products
        {
            ProductData.lsProducts.Add(new Products(txtProductName.Text,Int32.Parse(txtProductID.Text), Int32.Parse(txtProductPrice.Text), Int32.Parse(txtProductQty.Text)));
            Reset();
            foreach (var vals in ProductData.lsProducts)
            {
                MessageBox.Show(vals.ToString(), "Data you entered",MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
         private void lsOutput_Edit_SelectionChanged(object sender, SelectionChangedEventArgs e)//NB beware of namng conventions when labelling list box
        {
            if (lsOutput_Edit.SelectedIndex>=0)
            {
                String test = lsOutput_Edit.SelectedIndex.ToString();
                //MessageBox.Show(test, "Data you entered", MessageBoxButton.OK, MessageBoxImage.Information);
                Products SelectedItem = ProductData.lsProducts[lsOutput_Edit.SelectedIndex];
                txtProductID_Edit.Text = SelectedItem.IID.ToString();
                txtProductName_Edit.Text = SelectedItem.StrProduct;
                txtProductPrice_Edit.Text = SelectedItem.IPrice.ToString();
                txtProductQty_Edit.Text = SelectedItem.IQty.ToString();
            }           
        }
    }
}
