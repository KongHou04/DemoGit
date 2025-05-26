using DemoGit.Entities;

namespace DemoGit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Product> products = new List<Product>();

            Console.WriteLine("=== NHẬP THÔNG TIN SẢN PHẨM ===");

            while (true)
            {
                Product product = new Product();

                Console.Write("Nhập ID sản phẩm: ");
                product.Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nhập tên sản phẩm: ");
                product.Name = Console.ReadLine() ?? "";

                products.Add(product);

                Console.Write("Bạn có muốn nhập thêm sản phẩm không? (y/n): ");
                string? cont = Console.ReadLine();
                if (cont == null || cont.ToLower() != "y")
                {
                    break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n=== DANH SÁCH SẢN PHẨM ===");
            Console.WriteLine("{0,-5} | {1,-30}", "ID", "Tên sản phẩm");
            Console.WriteLine(new string('-', 40));

            foreach (var p in products)
            {
                Console.WriteLine("{0,-5} | {1,-30}", p.Id, p.Name);
            }

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}
