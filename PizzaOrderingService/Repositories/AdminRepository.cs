using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using PizzaOrderingService.Data;
using PizzaOrderingService.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaOrderingService.Repositories
{
    public class AdminRepository
    {
        private readonly AppDbContext _context;
        private readonly IServiceProvider _serviceProvider;

        public AdminRepository(AppDbContext context, IServiceProvider serviceProvider)
        {
            _context = context;
            _serviceProvider = serviceProvider;
        }
    }
}
