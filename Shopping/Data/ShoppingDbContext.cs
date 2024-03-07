using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shopping.Models;

namespace Shopping.Data
{
    public class ShoppingDbContext:IdentityDbContext<ApplicationUser> //so we can add authentication and authorization,that is microsoft build
    {
        public ShoppingDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<ApplicationUser> ApplicationUsers {  get; set; }//this will not create a table ,it will act as a navigation property,efcore knows we are extending identityUser table
        public DbSet<MenuItem> MenuItems {  get; set; } //creating a table with MenuItem values and naming the table MenuItems 
  
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<MenuItem>().HasData(
                new MenuItem
                {
                    Id = 1,
                    Name = "Spring Roll",
                    Description = "Fusc thdfnfnosnos sjnsodfn ,sdfnsodnonsf ,sfnsofninwofninsf",
                    Image = "https://images.pexels.com/photos/2059151/pexels-photo-2059151.jpeg?auto=compress&cs=tinysrgb&w=400",
                    Price = 7.99,
                    Category = "Appetizer",
                    SpecialTag ="",
                },
                 new MenuItem
                 {
                     Id = 2,
                     Name = "MeatPie ",
                     Description = "iscnnosdincvo sovnsdionvsdonv kxviovnsiondvosnvio",
                     Image = "https://images.pexels.com/photos/8272528/pexels-photo-8272528.jpeg?auto=compress&cs=tinysrgb&w=400",
                     Price = 500,
                     Category = "Appetizer",
                     SpecialTag = "",
                 },
                  new MenuItem
                  {
                      Id = 3,
                      Name = "Doughnut",
                      Description = "jscnsovnsovns sdcvnsiodvnsov osvnosivnsdiovnosdv",
                      Image = "https://images.pexels.com/photos/3253735/pexels-photo-3253735.jpeg?auto=compress&cs=tinysrgb&w=400",
                      Price = 300,
                      Category = "Appetizer",
                      SpecialTag = "",
                  },

                   new MenuItem
                   {
                       Id = 4,
                       Name = "Fish Pie",
                       Description = "jdsjcnsdocu  scmciamasimeimfoiw iowdweodeowdoed",
                       Image = "https://images.pexels.com/photos/5900509/pexels-photo-5900509.jpeg?auto=compress&cs=tinysrgb&w=400",
                       Price = 250,
                       Category = "Appetizer",
                       SpecialTag = "",
                   },

                    new MenuItem
                    {
                        Id = 5,
                        Name = "Salad",
                        Description = "sjdcjscnsci koscmscoisdc iscmosdicsmdm ",
                        Image = "https://images.pexels.com/photos/1211887/pexels-photo-1211887.jpeg?auto=compress&cs=tinysrgb&w=400",
                        Price = 203,
                        Category = "Appetizer",
                        SpecialTag = "",
                    },

                     new MenuItem
                     {
                         Id = 6,
                         Name = "Chips",
                         Description = "opowiqmdpm piemd0mim eimdwpedmoif",
                         Image = "https://images.pexels.com/photos/1583884/pexels-photo-1583884.jpeg?auto=compress&cs=tinysrgb&w=400",
                         Price = 100,
                         Category = "Food",
                         SpecialTag = "",
                     },
                      new MenuItem
                      {
                          Id = 7,
                          Name = "Bread",
                          Description = "sdjsicscj cmsdjcnsucnsc c ",
                          Image = "https://images.pexels.com/photos/1775043/pexels-photo-1775043.jpeg?auto=compress&cs=tinysrgb&w=400",
                          Price = 300,
                          Category = "Food",
                          SpecialTag = "",
                      },
                       new MenuItem
                       {
                           Id = 8,
                           Name = "Coke",
                           Description = " lorem ipsdum scnuanoadnap",
                           Image = "https://images.pexels.com/photos/50593/coca-cola-cold-drink-soft-drink-coke-50593.jpeg?auto=compress&cs=tinysrgb&w=400",
                           Price = 250,
                           Category = "Drink",
                           SpecialTag = "",
                       },
                        new MenuItem
                        {
                            Id = 9,
                            Name = "Fanta",
                            Description = "jhsodd scmdciocwiec dcnocweic",
                            Image = "https://images.pexels.com/photos/13950097/pexels-photo-13950097.jpeg?auto=compress&cs=tinysrgb&w=400",
                            Price = 250,
                            Category = "Drink",
                            SpecialTag = "",
                        },
                         new MenuItem
                         {
                             Id = 10,
                             Name = "Jollof rice",
                             Description = "cjskcnsjcdnowucn naodiadocm jnodnondiqnd jdqdiodnqodnqcqwk",
                             Image = "https://images.pexels.com/photos/6066056/pexels-photo-6066056.jpeg?auto=compress&cs=tinysrgb&w=400",
                             Price = 1500,
                             Category = "Food",
                             SpecialTag = "",
                         },
                          new MenuItem
                          {
                              Id = 11,
                              Name = "Fried rice",
                              Description = "poewerid idemdwei diamasism",
                              Image = "https://images.pexels.com/photos/6937455/pexels-photo-6937455.jpeg?auto=compress&cs=tinysrgb&w=400",
                              Price = 430,
                              Category = "Food",
                              SpecialTag = "",
                          },

                           new MenuItem
                           {
                               Id = 12,
                               Name = "Cake",
                               Description = "xsdcwefo cwcmiwocpxadp pspocmsdomcsdoicmpo scspocsdcpocspmi",
                               Image = "https://images.pexels.com/photos/1055272/pexels-photo-1055272.jpeg?auto=compress&cs=tinysrgb&w=400",
                               Price = 7.99,
                               Category = "Snacks",
                               SpecialTag = "",
                           }
                );
        }
    }
}
