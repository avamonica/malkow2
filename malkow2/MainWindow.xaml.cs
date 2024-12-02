using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace malkow2
{
    public partial class MainWindow : Window
    {
        // коллекция хранения
        public ObservableCollection<Product> Products { get; set; } = new ObservableCollection<Product>();

        public MainWindow()
        {
            InitializeComponent();

            // text
            Products.Add(new Product("Ноутбук", 50000m, "Игровой ноутбук, хороший процессор, не греется"));
            Products.Add(new Product("Смартфон", 30000m, "Смартфон, крепкий корпус не разобьешь, пока не захочешь"));
            Products.Add(new Product("Наушники", 5000m, "Беспроводные, в трех цветах на выбор"));

            ProductList.ItemsSource = Products;
        }

        // выбор товара
        private void ProductListSelectionChange(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (ProductList.SelectedItem is Product selectedProduct)
            {
                // деконстр извлеч
                var (name, price, description) = selectedProduct;

                // отображение
                ProductName.Text = $"название: {name}";
                ProductPrice.Text = $"цена: {price:C}";
                ProductDescription.Text = $"описание: {description}";
            }

        }
    }
}