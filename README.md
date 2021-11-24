# cs-winform-databinding-vs2010

```
        private void button2_Click(object sender, EventArgs e)
        {
            var products = new List<Product>();
            products.Add(new Product(1, "p1"));
            products.Add(new Product(2, "p2"));
            products.Add(new Product(5, "p1"));
            products.Add(new Product(3, "p31"));

            var result = products.FindAll(x => x.ProductName == "p1");
            foreach (var val in result)
            {
                Console.WriteLine(val.ProductId);
                // 1 5
            }

            var result2 = products.Exists(x => x.ProductName == "p1");
            Console.WriteLine("result2:" + string.Join(",", result2));
            // true

        }


    public class Product
    {
        public Product(int productId, string productName)
        {
            ProductId = productId;
            ProductName = productName;
        }

        public int ProductId { get; }
        public string ProductName { get; }
    }
```
