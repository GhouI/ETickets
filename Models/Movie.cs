﻿using System.ComponentModel.DataAnnotations;
using eTickets.Data;

namespace eTickets.Models
{
    public class Movie
    {
        [Key] 
        public int Id { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public MovieCategory MovieCategory { get; set; }
    }
}