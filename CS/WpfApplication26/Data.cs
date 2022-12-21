using System.Collections.Generic;

namespace WpfApplication26 {

    public class Category {
        public Category(string name) {
            Name = name;
            Products = new List<Product>();
        }
        public string Name { get; set; }
        public List<Product> Products { get; }
    }
    public class Product {
        public Product(string name, double price) {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class DataSource {
        public static List<Category> GetCategories() {
            var categories = new List<Category>();
            categories.Add(new Category("First"));
            categories[0].Products.Add(new Product("Product 1.1", 10));
            categories[0].Products.Add(new Product("Product 1.2", 20));
            categories[0].Products.Add(new Product("Product 1.3", 30));
            categories[0].Products.Add(new Product("Product 1.4", 40));
            categories.Add(new Category("Second"));
            categories[1].Products.Add(new Product("Product 2.1", 10));
            categories[1].Products.Add(new Product("Product 2.2", 20));
            categories.Add(new Category("Third"));
            categories[2].Products.Add(new Product("Product 3.1", 10));
            categories[2].Products.Add(new Product("Product 3.2", 20));
            categories[2].Products.Add(new Product("Product 3.4", 40));
            categories.Add(new Category("Fourth"));
            categories[3].Products.Add(new Product("Product 4.1", 10));
            categories[3].Products.Add(new Product("Product 4.2", 20));
            categories[3].Products.Add(new Product("Product 4.3", 30));
            categories[3].Products.Add(new Product("Product 4.4", 40));
            return categories;
        }
        public List<Category> Categories { get; }
    }
}
