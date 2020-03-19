using System;
using System.Collections.Generic;
using System.Linq;
using PizzaOrderingService.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace PizzaOrderingService.Data
{
    public class DbInitializer
    {
        public static void Initialize(AppDbContext context, IServiceProvider service)
        {
            context.Database.EnsureCreated();

            var roleManager = service.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = service.GetRequiredService<UserManager<IdentityUser>>();

            if (context.Pizzas.Any())
            {
                return;
            }

            ClearDatabase(context);
            CreateAdminRole(context, roleManager, userManager);
            SeedDatabase(context, roleManager, userManager);
        }

        private static void CreateAdminRole(AppDbContext context, RoleManager<IdentityRole> _roleManager, UserManager<IdentityUser> _userManager)
        {
            bool roleExists = _roleManager.RoleExistsAsync("Admin").Result;
            if (roleExists)
            {
                return;
            }
            
            var role = new IdentityRole()
            {
                Name = "Admin"
            };
            _roleManager.CreateAsync(role).Wait();

            var user = new IdentityUser()
            {
                UserName = "admin",
                Email = "admin@gmail.com"
            };

            string adminPassword = "qwerty123PASS";
            var userResult =  _userManager.CreateAsync(user, adminPassword).Result;

            if (userResult.Succeeded)
            {
                _userManager.AddToRoleAsync(user, "Admin").Wait();
            }
        }

        private static void SeedDatabase(AppDbContext _context, RoleManager<IdentityRole> _roleManager, UserManager<IdentityUser> _userManager)
        {
            var cat1 = new Categories { Name = "Стандартные", Description = "Description1" };
            var cat2 = new Categories { Name = "Специальные", Description = "Description2" };
            var cat3 = new Categories { Name = "Новые", Description = "Description3" };

            var cats = new List<Categories>()
            {
                cat1, cat2, cat3
            };

            var piz1 = new Pizzas { Name = "Пицца Охотничья", Price = 129.00M, Category = cat1, Description = "Охотничьи колбаски, молочные колбаски, сыр моцарелла, вешенки, шампиньоны, сладкий лук, перец болгарский, соус BBQ, соус маринара, петрушка", ImageUrl = "https://mafia.ua/storage/editor/fotos/480x0/picca-ohotnichya_1542267892836.jpeg", IsPizzaOfTheWeek = false };
            var piz2 = new Pizzas { Name = "Карбонара метровая", Price = 339.00M, Category = cat3, Description = "Сыр моцарелла, ветчина, грудинка, шампиньоны, пармезан, помидоры черри", ImageUrl = "https://mafia.ua/storage/editor/fotos/480x0/karbonara-metrovaya_1566297127558.jpeg", IsPizzaOfTheWeek = false };
            var piz3 = new Pizzas { Name = "Американо метровая", Price = 339.00M, Category = cat1, Description = "Соус BBQ, соус маринара, сыр моцарелла, горчица, филе куриное sous-vide, колбаски охотничьи, пепперони, лук конфитюр, кукуруза, перец болгарский", ImageUrl = "https://mafia.ua/storage/editor/fotos/480x0/amerikano-metrovaya_1566296641461.jpeg", IsPizzaOfTheWeek = true };
            var piz4 = new Pizzas { Name = "Маргарита", Price = 89.00M, Category = cat1, Description = "Соус маринара, помидоры, сыр моцарелла, соус песто.", ImageUrl = "https://mafia.ua/storage/editor/fotos/480x0/margarita_156706066239.jpeg", IsPizzaOfTheWeek = false };
            var piz5 = new Pizzas { Name = "Карбонара", Price = 186.00M, Category = cat2, Description = "Сыр моцарелла, ветчина, грудинка, шампиньоны, пармезан, помидоры черри", ImageUrl = "https://mafia.ua/storage/editor/fotos/480x0/karbonara_1567060589165.jpeg", IsPizzaOfTheWeek = true };
            var piz6 = new Pizzas { Name = "Поло", Price = 135.00M, Category = cat1, Description = "Сыр моцарелла, соус маринара, соус ВВQ, чеснок, ананас, филе куриное sous-vide, перец болгарский", ImageUrl = "https://mafia.ua/storage/editor/fotos/480x0/pollo_1567060914824.jpeg", IsPizzaOfTheWeek = true };
            var piz7 = new Pizzas { Name = "Гурмео", Price = 165.00M, Category = cat1, Description = "Соус BBQ, филе куриное sous-vide, ветчина, колбаски охотничьи, пеперони, сыр моцарелла, шампиньоны, лук репчатый, петрушка", ImageUrl = "https://mafia.ua/storage/editor/fotos/480x0/gurmeo_1567060279780.jpeg", IsPizzaOfTheWeek = false };
            var piz8 = new Pizzas { Name = "Четыре сыра", Price = 149.00M, Category = cat2, Description = "Сливочный соус, сыр моцарелла, сыр дор-блю, сыр чеддер, груша, сыр пармезан, орех грецкий", ImageUrl = "https://mafia.ua/storage/editor/fotos/480x0/chetyre-syra_1567059967719.jpeg", IsPizzaOfTheWeek = false };
            var piz9 = new Pizzas { Name = "Гурмео метровая", Price = 329.00M, Category = cat3, Description = "Соус BBQ, филе куриное sous-vide, ветчина, колбаски охотничьи, пепперони, сыр моцарелла, шампиньоны, лук репчатый, петрушка", ImageUrl = "https://mafia.ua/storage/editor/fotos/480x0/gurmeo-metrovaya_1566296981221.jpeg", IsPizzaOfTheWeek = false };

            var pizs = new List<Pizzas>()
            {
                piz1, piz2, piz3, piz4, piz5, piz6, piz7, piz8, piz9
            };

            var user1 = new IdentityUser { UserName = "user1@gmail.com", Email = "user1@gmail.com" };
            var user2 = new IdentityUser { UserName = "user2@gmail.com", Email = "user2@gmail.com" };
            var user3 = new IdentityUser { UserName = "user3@gmail.com", Email = "user3@gmail.com" };

            string userPassword = "Password123";

            var users = new List<IdentityUser>()
            {
                user1, user2, user3
            };

            foreach (var user in users)
            {
                _userManager.CreateAsync(user, userPassword).Wait();
            }

            var ing1 = new Ingredients { Name = "Охотничьи колбаски" };
            var ing2 = new Ingredients { Name = "Сыр моцарелла" };
            var ing3 = new Ingredients { Name = "Соус BBQ" };
            var ing4 = new Ingredients { Name = "Соус маринара" };
            var ing5 = new Ingredients { Name = "Сливочный соус" };
            var ing6 = new Ingredients { Name = "Горчица" };
            var ing7 = new Ingredients { Name = "Пармезан" };
            var ing8 = new Ingredients { Name = "Помидоры черри" };
            var ing9 = new Ingredients { Name = "Шампиньоны" };
            var ing10 = new Ingredients { Name = "Ананас" };
            var ing11 = new Ingredients { Name = "Ветчина" };
            var ing12 = new Ingredients { Name = "Молочные колбаски" };
            var ing13 = new Ingredients { Name = "Грудинка" };
            var ing14 = new Ingredients { Name = "Лук репчатый" };
            var ing15 = new Ingredients { Name = "Петрушка" };
            var ing16 = new Ingredients { Name = "Пепперони" };

            var ings = new List<Ingredients>()
            {
                ing1, ing2, ing3, ing4, ing5, ing6, ing7, ing8, ing9, ing10, ing11, ing12, ing13, ing14, ing15, ing16
            };

            var pizIngs = new List<PizzaIngredients>()
            {
                new PizzaIngredients { Ingredient = ing1, Pizza = piz1 },
                new PizzaIngredients { Ingredient = ing2, Pizza = piz1 },
                new PizzaIngredients { Ingredient = ing3, Pizza = piz1 },
                new PizzaIngredients { Ingredient = ing4, Pizza = piz1 },
                new PizzaIngredients { Ingredient = ing5, Pizza = piz1 },

                new PizzaIngredients { Ingredient = ing6, Pizza = piz2 },
                new PizzaIngredients { Ingredient = ing7, Pizza = piz2 },
                new PizzaIngredients { Ingredient = ing8, Pizza = piz2 },
                new PizzaIngredients { Ingredient = ing9, Pizza = piz2 },
                new PizzaIngredients { Ingredient = ing10, Pizza = piz2 },

                new PizzaIngredients { Ingredient = ing11, Pizza = piz3 },
                new PizzaIngredients { Ingredient = ing12, Pizza = piz3 },
                new PizzaIngredients { Ingredient = ing13, Pizza = piz3 },
                new PizzaIngredients { Ingredient = ing14, Pizza = piz3 },
                new PizzaIngredients { Ingredient = ing15, Pizza = piz3 },

                new PizzaIngredients { Ingredient = ing16, Pizza = piz4 },
                new PizzaIngredients { Ingredient = ing1, Pizza = piz4 },
                new PizzaIngredients { Ingredient = ing2, Pizza = piz4 },
                new PizzaIngredients { Ingredient = ing3, Pizza = piz4 },
                new PizzaIngredients { Ingredient = ing4, Pizza = piz4 },


                new PizzaIngredients { Ingredient = ing5, Pizza = piz5 },
                new PizzaIngredients { Ingredient = ing6, Pizza = piz5 },
                new PizzaIngredients { Ingredient = ing7, Pizza = piz5 },
                new PizzaIngredients { Ingredient = ing8, Pizza = piz5 },
                new PizzaIngredients { Ingredient = ing9, Pizza = piz5 },

                new PizzaIngredients { Ingredient = ing10, Pizza = piz6 },
                new PizzaIngredients { Ingredient = ing11, Pizza = piz6 },
                new PizzaIngredients { Ingredient = ing12, Pizza = piz6 },
                new PizzaIngredients { Ingredient = ing13, Pizza = piz6 },
                new PizzaIngredients { Ingredient = ing14, Pizza = piz6 },

                new PizzaIngredients { Ingredient = ing15, Pizza = piz7 },
                new PizzaIngredients { Ingredient = ing16, Pizza = piz7 },
                new PizzaIngredients { Ingredient = ing1, Pizza = piz7 },
                new PizzaIngredients { Ingredient = ing2, Pizza = piz7 },
                new PizzaIngredients { Ingredient = ing3, Pizza = piz7 },

                new PizzaIngredients { Ingredient = ing4, Pizza = piz8 },
                new PizzaIngredients { Ingredient = ing5, Pizza = piz8 },
                new PizzaIngredients { Ingredient = ing6, Pizza = piz8 },
                new PizzaIngredients { Ingredient = ing7, Pizza = piz8 },

                new PizzaIngredients { Ingredient = ing8, Pizza = piz9 },
                new PizzaIngredients { Ingredient = ing9, Pizza = piz9 },
                new PizzaIngredients { Ingredient = ing10, Pizza = piz9 },
                new PizzaIngredients { Ingredient = ing11, Pizza = piz9 },
                new PizzaIngredients { Ingredient = ing12, Pizza = piz9 },
            };

            var ord1 = new Order
            {
                FirstName = "Petro",
                LastName = "Pavlenko",
                Address = "Street 1",
                City = "Kharkiv",
                Email = "user1@gmail.com",
                OrderPlaced = DateTime.Now.AddDays(-2),
                PhoneNumber = "123456789",
                User = user1,
                OrderTotal = 780.00M,
            };

            var ord2 = new Order { };
            var ord3 = new Order { };

            var orderLines = new List<OrderDetail>()
            {
                new OrderDetail { Order=ord1, Pizza=piz1, Amount=2, Price=piz1.Price},
                new OrderDetail { Order=ord1, Pizza=piz3, Amount=1, Price=piz3.Price},
                new OrderDetail { Order=ord1, Pizza=piz5, Amount=3, Price=piz5.Price},
            };

            var orders = new List<Order>()
            {
                ord1
            };

            _context.Categories.AddRange(cats);
            _context.Pizzas.AddRange(pizs);
            _context.Orders.AddRange(orders);
            _context.OrderDetails.AddRange(orderLines);
            _context.Ingredients.AddRange(ings);
            _context.PizzaIngredients.AddRange(pizIngs);

            _context.SaveChanges();
        }

        private static void ClearDatabase(AppDbContext _context)
        {
            var pizzaIngredients = _context.PizzaIngredients.ToList();
            _context.PizzaIngredients.RemoveRange(pizzaIngredients);

            var ingredients = _context.Ingredients.ToList();
            _context.Ingredients.RemoveRange(ingredients);

            var shoppingCartItems = _context.ShoppingCartItems.ToList();
            _context.ShoppingCartItems.RemoveRange(shoppingCartItems);

            var users = _context.Users.ToList();
            var userRoles = _context.UserRoles.ToList();

            foreach (var user in users)
            {
                if (!userRoles.Any(r => r.UserId == user.Id))
                {
                    _context.Users.Remove(user);
                }
            }

            var orderDetails = _context.OrderDetails.ToList();
            _context.OrderDetails.RemoveRange(orderDetails);

            var orders = _context.Orders.ToList();
            _context.Orders.RemoveRange(orders);

            var pizzas = _context.Pizzas.ToList();
            _context.Pizzas.RemoveRange(pizzas);

            var categories = _context.Categories.ToList();
            _context.Categories.RemoveRange(categories);

            _context.SaveChanges();
        }
    }
}
