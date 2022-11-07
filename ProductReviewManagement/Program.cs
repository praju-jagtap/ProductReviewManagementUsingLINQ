using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<ProductReview> productReviewlist = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Excellent", isLike = true },
                new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Excellent", isLike = true },
                new ProductReview() { ProductId = 2, UserId = 2, Rating = 4, Review = "Good",     isLike = false },
                new ProductReview() { ProductId = 4, UserId = 3, Rating = 4, Review = "Good",     isLike = true },
                new ProductReview() { ProductId = 3, UserId = 3, Rating = 3, Review = "Average",  isLike = false },
                new ProductReview() { ProductId = 3, UserId = 4, Rating = 5, Review = "Excellent", isLike = true },
                new ProductReview() { ProductId = 4, UserId = 5, Rating = 3, Review = "Average",  isLike = true },
                new ProductReview() { ProductId = 5, UserId = 5, Rating = 2, Review = "Bad",      isLike = true },
                new ProductReview() { ProductId = 5, UserId = 6, Rating = 2, Review = "Bad",      isLike = true },
                new ProductReview() { ProductId = 6, UserId = 7, Rating = 1, Review = "Very Bad", isLike = true },
                new ProductReview() { ProductId = 6, UserId = 7, Rating = 3, Review = "Average",  isLike = true }
            };
            foreach (var list in productReviewlist)
            {
                Console.WriteLine("Product Id :" + list.ProductId + "\t" + "User Id :" + list.UserId + "\t" + "Rating :" + list.Rating + "\t" + "Review :" + list.Review + "\t" + "Is Like :" + list.isLike);
            }
            //UC2
            Console.WriteLine("\n-------- Display Top Three Records Who's Rating is High ------\n");
            ProductManagement.RetrieveTopThreeRatedRecords(productReviewlist);

            //UC3
            Console.WriteLine("\n------- Retrieves the records with rating greater than 3 and id=1 or 4 or 9 ------\n");
            ProductManagement.RetrieveRecordsWithGreaterThanThreeRating(productReviewlist);
            
            //UC4
            Console.WriteLine("\n------- Retrieves the count of reviews for each productID using groupBy -----\n");
            ProductManagement.RetrieveCountOfReviewForEachProductId(productReviewlist);

            //UC5
            Console.WriteLine("\n-------- Retrieves only the product id and review of all records ---------\n");
            ProductManagement.RetrieveProductIDAndReviewOfAllRecords(productReviewlist);
            
            //UC6
            Console.WriteLine("\n--------- Skip top 5 Records from the List and Display other Records -------\n");
            ProductManagement.SkipTopFiveRecords(productReviewlist);
            
            //UC7
            Console.WriteLine("\n--------- Retrieve only productId and review from the list for all records using LINQ select operator ------\n");
            ProductManagement.RetrieveProductIDAndReviewUsingLambdaSyntax(productReviewlist);
            Console.ReadLine();
        }
    }
}
