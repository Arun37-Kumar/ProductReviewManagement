using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    class ProductReview
    {
        
        /// <summary>
        ///Data Variables 
        /// </summary>
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public double Rating { get; set; }
        public string Review { get; set; }
        public bool IsLike { get; set; }

        /// <summary>
        /// Method To Override ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Product Id: {ProductId},  User Id: {UserId},  Product Rating: {Rating},  Product Review: {Review},  IsLike: {IsLike}";
        }
    }
}
