using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            ReviewManager manage = new ReviewManager();
            List<ProductReview> products = new List<ProductReview>();

            Console.WriteLine("1 : Add Product Review ");
            Console.WriteLine("2 : Retrieve top 3 ratings ");
            Console.Write("Enter the option  : ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1: // Adding the product review and showing the list
                    manage.AddProductReview(products);
                    manage.ShowList(products);
                    break;
                case 2: // Retriving the products
                    manage.AddProductReview(products);
                    manage.ShowList(products);
                    manage.RetrieveData(products);
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
