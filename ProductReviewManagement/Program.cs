using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
            Console.WriteLine("3 : Retrive record with rating greater than 3 and product Id = 1,4,9 ");
            Console.WriteLine("4 : Retrive Count of review by Product Id ");
            Console.WriteLine("5 : Retrieve Product Id And Review ");
            Console.WriteLine("6 : Skip top 5 Records ");
            Console.WriteLine("7 : Retrieve only Product Id and Reviews ");
            Console.WriteLine("8 : Create Data Table and add the values ");
            Console.WriteLine("9 : Method to retreive records where isLike is true ");
            Console.WriteLine("10 : Find Average and Sum ");
            Console.WriteLine("11 : Get Nice Review Records form Table");
            Console.WriteLine("12 : retreive records from datatable of particular user id order by rating");
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
                case 3: // Retrieving the products with rating greater than 3 and product id with 1,4,9
                    manage.AddProductReview(products);
                    manage.RetrieveSpecificRecords(products);
                    break;
                case 4: // Retriving count of review by Product Id 
                    manage.AddProductReview(products);
                    manage.RetrieveProductIdCount(products);
                    break;
                case 5: // Retrieve ProductId and reviews
                    manage.AddProductReview(products);
                    manage.RetrieveProductIdAndReview(products);
                    break;
                case 6: // Skip top 5 records
                    manage.AddProductReview(products);
                    manage.SkipTopFiveRecords(products);
                    break;
                case 7: // Retrieve Only product Id and Reviews
                    manage.AddProductReview(products);
                    manage.RetrieveOnlyProductIdAndReview(products);
                    break;
                case 8: //Create Data Table and add the values
                    manage.CreateDataTable(products);
                    break;
                case 9: // Method to retreive records where isLike is true
                    manage.CreateDataTable(products);
                    manage.RetreiveRecordsForIsLikeTrue(products);
                    break;
                case 10:
                    manage.CreateDataTable(products);
                    manage.FindAvgRatingForEachProductId(products);
                    break;
                case 11:
                    manage.GetNiceReviewRecordsFromTable(products);
                    break;
                case 12:
                    manage.GetRecordsBasedOnUserId(products,1);
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }


    }
}
