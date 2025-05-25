namespace DemoGit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Category> categories = new List<Category>();

            Console.WriteLine("=== NHẬP THÔNG TIN DANH MỤC ===");

            while (true)
            {
                Category category = new Category();

                Console.Write("Nhập ID: ");
                category.Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nhập tên danh mục: ");
                category.Name = Console.ReadLine() ?? "";

                Console.Write("Nhập mô tả (có thể để trống): ");
                category.Description = Console.ReadLine();

                categories.Add(category);

                Console.Write("Bạn có muốn nhập thêm danh mục không? (y/n): ");
                string? cont = Console.ReadLine();
                if (cont == null || cont.ToLower() != "y")
                {
                    break;
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n=== DANH SÁCH DANH MỤC ===");
            Console.WriteLine("{0,-5} | {1,-20} | {2}", "ID", "Tên danh mục", "Mô tả");
            Console.WriteLine(new string('-', 50));

            foreach (var cat in categories)
            {
                Console.WriteLine("{0,-5} | {1,-20} | {2}", cat.Id, cat.Name, cat.Description);
            }

            Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
            Console.ReadKey();
        }
    }
}

