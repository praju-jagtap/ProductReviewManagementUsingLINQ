﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductManagement
    {
        // UC2-Retrieve top 3 records from the list Who’s Rating is high using LINQ
        public static void RetrieveTopThreeRatedRecords(List<ProductReview> list)
        {
            //using Query Syntax
            var recordedData = (from products in list orderby products.Rating descending select products).Take(3);
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("Product Id :" + productReview.ProductId + "\t" + "User Id :" + productReview.UserId + "\t" + "Rating :" + productReview.Rating + "\t" + "Review :" + productReview.Review + "\t" + "Is Like :" + productReview.isLike);
            }
        }
        //UC3-Retrieves the records with rating greater than three.
        public static void RetrieveRecordsWithGreaterThanThreeRating(List<ProductReview> list)
        {
            var recordedData = (from productReviews in list where (productReviews.ProductId == 1 || productReviews.ProductId == 4 || productReviews.ProductId == 9) && productReviews.Rating > 3 select productReviews);
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("Product Id :" + productReview.ProductId + "\t" + "User Id :" + productReview.UserId + "\t" + "Rating ;" + productReview.Rating + "\t" + "Review :" + productReview.Review + "\t" + "Is Like :" + productReview.isLike);
            }
        }
        // UC4-Retrieves the count of reviews for each productID using groupBy.
        public static void RetrieveCountOfReviewForEachProductId(List<ProductReview> list)
        {
            var recordedData = (list.GroupBy(p => p.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() }));
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("ProductId : " + productReview.ProductId + "  Count : " + productReview.Count);
            }
        }
        // UC5 Retrieves only the product id and review of all records.
        public static void RetrieveProductIDAndReviewOfAllRecords(List<ProductReview> list)
        {
            var recordedData = (from products in list select new { ProductId = products.ProductId, Review = products.Review });
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("Product ID : " + productReview.ProductId + "\t" + "Review : " + productReview.Review);
            }
        }
    }
}
