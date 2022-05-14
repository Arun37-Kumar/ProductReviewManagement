using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    class ReviewManager
    {
        /// <summary>
        /// Adding the Products to the List
        /// UC1
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        public List<ProductReview> AddProductReview(List<ProductReview> products)
        {
            try
            {
                products.Add(new ProductReview() { ProductId = 1, UserId = 1, Review = "Good", Rating = 5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 2, UserId = 2, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductReview() { ProductId = 3, UserId = 3, Review = "Average", Rating = 3, IsLike = false });
                products.Add(new ProductReview() { ProductId = 4, UserId = 4, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductReview() { ProductId = 5, UserId = 5, Review = "Very Good", Rating = 5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 6, UserId = 6, Review = "Bad", Rating = 2, IsLike = false });
                products.Add(new ProductReview() { ProductId = 7, UserId = 7, Review = "Very Good", Rating = 5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 8, UserId = 15, Review = "Average", Rating = 3.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 9, UserId = 9, Review = "Average", Rating = 3.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 10, UserId = 10, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductReview() { ProductId = 2, UserId = 1, Review = "Very Good", Rating = 5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 3, UserId = 2, Review = "Bad", Rating = 2.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 5, UserId = 3, Review = "Good", Rating = 4.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 7, UserId = 4, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductReview() { ProductId = 9, UserId = 5, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductReview() { ProductId = 11, UserId = 6, Review = "Average", Rating = 3.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 1, UserId = 7, Review = "Bad", Rating = 2.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 3, UserId = 8, Review = "Good", Rating = 4.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 2, UserId = 8, Review = "Bad", Rating = 2.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 4, UserId = 9, Review = "Average", Rating = 3.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 6, UserId = 10, Review = "Good", Rating = 4.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 8, UserId = 11, Review = "Average", Rating = 3, IsLike = false });
                products.Add(new ProductReview() { ProductId = 9, UserId = 12, Review = "Good", Rating = 4.5, IsLike = true });
                products.Add(new ProductReview() { ProductId = 5, UserId = 13, Review = "Average", Rating = 3.5, IsLike = false });
                products.Add(new ProductReview() { ProductId = 10, UserId = 14, Review = "Average", Rating = 3, IsLike = false });

                //To Check for the number of Entry
                int count = products.Count;
                if (count != 0)
                    Console.WriteLine("Successfully Added The Products to the list");
                else
                    Console.WriteLine("No Products Added to the List");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return products;
        }

        /// <summary>
        /// UC1
        /// Showing the List
        /// </summary>
        /// <param name="products"></param>
        public void ShowList(List<ProductReview> products)
        {
            try
            {
                if (products != null)
                {
                    foreach (ProductReview product in products)
                    {
                        Console.WriteLine(product);
                    }
                }
                else
                {
                    Console.WriteLine("No Products Reviews Added In The List");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// UC2 Retrieving Top 3 Ratings from the product
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        public List<ProductReview> RetrieveData(List<ProductReview> products)
        {
            //Retrive top 3 rating using LINQ
            if (products != null)
            {
                var productRatingRetrieve = products.OrderByDescending(rating => rating.Rating).Take(3).ToList();
                Console.WriteLine("Printing Top 3 Ratings : ");
                ShowList(productRatingRetrieve);
                return productRatingRetrieve;
            }
            else
            {
                Console.WriteLine("Products not found in the List");
                return default;
            }
        }


        /// <summary>
        ///UC3 - Method to retrieve records from the list rating greater than 3 and product id 1 or 4 or 9 using LINQ 
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        public List<ProductReview> RetrieveSpecificRecords(List<ProductReview> products)
        {
            if (products != null)
            {
                //LINQ 
                var retrieveRating = (from product in products where (product.ProductId == 1 || product.ProductId == 4 || product.ProductId == 9) && product.Rating > 3 select product).ToList();

                Console.WriteLine("\nRecords Based On Rating And ProductId");
                ShowList(retrieveRating);
                return retrieveRating;
            }
            else
            {
                Console.WriteLine("Products Review not found In The List");
                return default;
            }
        }

        /// <summary>
        /// UC5 Retrieve Product Id Count
        /// </summary>
        /// <param name="products"></param>
        public void RetrieveProductIdCount(List<ProductReview> products)
        {
            if (products != null)
            {
                var productCount = products.GroupBy(p => p.ProductId).Select(p => new { productId = p.Key, count = p.Count() });
                Console.WriteLine("Count the Product Review based on Product Id : ");
                foreach (var product in productCount)
                {
                    Console.WriteLine($"Product Id: { product.productId},  Product Count : { product.count} ");
                }
            }
            else
            {
                Console.WriteLine("Products not found in the List");
            }
        }

        /// <summary>
        /// UC5 Retrieve Product Id And Review
        /// </summary>
        /// <param name="products"></param>
        public void RetrieveProductIdAndReview(List<ProductReview> products)
        {
            if (products != null)
            {
                var countReviewId = products.Select(x => new { productId = x.ProductId, review = x.Review }).ToList();
                foreach (var product in countReviewId)
                {
                    Console.WriteLine($"Product Id : {product.productId}, Product Review : {product.review}");
                }
            }
            else
            {
                Console.WriteLine("Product List is empty");
            }
        }

        /// <summary>
        /// UC6 Skip top five records
        /// </summary>
        /// <param name="products"></param>
        public void SkipTopFiveRecords(List<ProductReview> products)
        {
            if (products != null)
            {
                var skipFiveRecords = (from product in products orderby product.Rating descending select product).Skip(5).ToList();
                foreach (var product in skipFiveRecords)
                {
                    Console.WriteLine(product);
                }
            }
            else
            {
                Console.WriteLine("List do not contains any data");
            }
        }

        /// <summary>
        /// UC7 Retrieve only Product Id's and Reviews from the list using SELECT LINQ
        /// </summary>
        /// <param name="products"></param>
        public void RetrieveOnlyProductIdAndReview(List<ProductReview> products)
        {
            if (products != null)
            {
                var retrieveIdAndReview = from product in products select product;
                foreach (var product in retrieveIdAndReview)
                {
                    Console.WriteLine($"Product Id : {product.ProductId}, Review : {product.Review}");
                }
            }
            else
            {
                Console.WriteLine("Product list is empty");
            }
        }

        /// <summary>
        /// UC8 Create DataTable    
        /// </summary>
        /// <param name="products"></param>
        /// <returns></returns>
        public DataTable CreateDataTable(List<ProductReview> products)
        {
            if (products != null)
            {
                DataTable dataTable = new DataTable();
                    
                //Adding the data to data table
                dataTable.Columns.Add("ProductId", typeof(int));
                dataTable.Columns.Add("UserId", typeof(int));
                dataTable.Columns.Add("Rating", typeof(double));
                dataTable.Columns.Add("Review", typeof(string));
                dataTable.Columns.Add("IsLike", typeof(bool));

                //Adding values to the data
                foreach (var product in products)
                {
                    dataTable.Rows.Add(product.ProductId, product.UserId, product.Review, product.IsLike);
                }
                Console.WriteLine("Successfully added the values!");
                return dataTable;
            }
            else
            {
                Console.WriteLine("Product Review not found in the List");
                return default;
            }
        }

        /// <summary>
        /// UC9 - Method to retreive records where isLike is true
        /// </summary>
        /// <param name="products"></param>
        public void RetreiveRecordsForIsLikeTrue(List<ProductReview> products)
        {
            if (products != null)
            {
                DataTable dataTable = CreateDataTable(products);
                var fetchRows = from table in dataTable.AsEnumerable() where table.Field<bool>("IsLike") == true select table;
                Console.WriteLine($"ProductId,  UserId,  Rating,  Review,  IsLike");
                foreach (var row in fetchRows)
                {
                    Console.WriteLine($"{row["ProductId"]},  {row["UserId"]},  {row["Rating"]},  {row["Review"]},  {row["IsLike"]}");
                }
            }
            else
            {
                Console.WriteLine("Products Review not found In The List");
            }
        }

        /// <summary>
        /// UC10 - Method to Find, retreive average rating for each product id
        /// </summary>
        /// <param name="products"></param>
        public void FindAvgRatingForEachProductId(List<ProductReview> products)
        {
            if (products != null)
            {
                DataTable dataTable = CreateDataTable(products);
                var resatingAverage = from product in dataTable.AsEnumerable() group product by product.Field<int>("ProductId") into temp select new { productid = temp.Key, average = Math.Round(temp.Average(x => x.Field<double>("Rating")), 3) };
                foreach (var row in resatingAverage)
                {
                    Console.WriteLine("Product Id: {0} \tAverage Ratings: {1}", row.productid, row.average);
                }
            }
            else
            {
                Console.WriteLine("Products Review not found In The List");
            }
        }

        /// <summary>
        /// UC11 - Method to retreive rating contains "Nice" or "Good" in review message from datatable
        /// </summary>
        /// <param name="products"></param>
        public void GetNiceReviewRecordsFromTable(List<ProductReview> products)
        {
            if (products != null)
            {
                DataTable dataTable = CreateDataTable(products);
                var resRows = from table in dataTable.AsEnumerable() where table.Field<string>("Review").Contains("Nice") || table.Field<string>("Review").Contains("Good") select table;
                Console.WriteLine($"ProductId,  UserId,  Rating,  Review,  IsLike");
                foreach (var row in resRows)
                {
                    Console.WriteLine($"{row["ProductId"]},  {row["UserId"]},  {row["Rating"]},  {row["Review"]},  {row["IsLike"]}");
                }
            }
            else
            {
                Console.WriteLine("No Products Review Added In The List");
            }
        }

    }
}
