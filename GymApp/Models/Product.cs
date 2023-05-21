﻿using System.Collections.Generic;

namespace GymApp.Models {
    public class Product {
        
         public string Machine_Name { get; set; } = string.Empty;
        public decimal? Machine_Price { get; set; }

        public static Product[] GetProducts() {

            Product Treadmil = new Product {
                Machine_Name = "Treadmil", Machine_Price = 275M
            };

            Product Cable_crossover_machine = new Product {
                Machine_Name = "Cable_crossover_machine", Machine_Price = 48.95M
            };

            return new Product[] { Treadmil, Cable_crossover_machine };
        
       
    }
    }

    
}
