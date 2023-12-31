﻿using System;

namespace first.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public Review() { }
    
            
         
         public Review(int productId,int userId)
         {
            ProductId = productId;
            UserId = userId;
            ReviewDate = DateTime.Now;
         }
    }
}
