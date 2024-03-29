﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tischreservierung.Models
{
    public class RestaurantOpeningTime
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime Day { get; set; }
        [DataType(DataType.Time)]
        public DateTime OpeningTime { get; set; }
        [DataType(DataType.Time)]
        public DateTime ClosingTime { get; set; }
        [ForeignKey(nameof(Restaurant))]
        public int RestaurantId { get; set; }
        public Restaurant? Restaurant { get; set; }
    }
}
