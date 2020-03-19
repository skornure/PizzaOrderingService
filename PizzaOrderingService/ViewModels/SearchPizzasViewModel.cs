﻿using PizzaOrderingService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingService.ViewModels
{
    public class SearchPizzasViewModel
    {
        [Required]
        [DisplayName("Serach")]
        public string SearchText { get; set; }

        public IEnumerable<Pizzas> PizzaList { get; set; }

    }
}
