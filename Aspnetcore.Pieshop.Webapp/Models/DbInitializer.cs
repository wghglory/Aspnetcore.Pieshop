using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Aspnetcore.Pieshop.Webapp.Models
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context = applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            // note: after first initializer seeds successfully, context.Categories is not null, AddRange won't call
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Pies.Any())
            {
                context.Pies.AddRange
                (
                    new Pie
                    {
                        Name = "Apple Pie",
                        Price = 12.95M,
                        ShortDescription = "Our famous apple pies!",
                        Category = Categories["Fruit pies"],
                        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                        InStock = true,
                        IsPieOfTheWeek = true,
                        ImageThumbnailUrl =
                            "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                        LongDescription =
                            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                        AllergyInformation = ""
                    },
                    new Pie
                    {
                        Name = "Blueberry Cheese Cake",
                        Price = 18.95M,
                        ShortDescription = "You'll love it!",
                        Category = Categories["Cheese cakes"],
                        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                        InStock = true,
                        IsPieOfTheWeek = false,
                        ImageThumbnailUrl =
                            "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                        LongDescription =
                            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                        AllergyInformation = ""
                    },
                    new Pie
                    {
                        Name = "Cheese Cake",
                        Price = 18.95M,
                        ShortDescription = "Plain cheese cake. Plain pleasure.",
                        Category = Categories["Cheese cakes"],
                        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
                        InStock = true,
                        IsPieOfTheWeek = false,
                        ImageThumbnailUrl =
                            "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
                        LongDescription =
                            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                        AllergyInformation = ""
                    },
                    new Pie
                    {
                        Name = "Cherry Pie",
                        Price = 15.95M,
                        ShortDescription = "A summer classic!",
                        Category = Categories["Fruit pies"],
                        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
                        InStock = true,
                        IsPieOfTheWeek = false,
                        ImageThumbnailUrl =
                            "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg",
                        LongDescription =
                            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                        AllergyInformation = ""
                    },
                    new Pie
                    {
                        Name = "Christmas Apple Pie",
                        Price = 13.95M,
                        ShortDescription = "Happy holidays with this pie!",
                        Category = Categories["Seasonal pies"],
                        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg",
                        InStock = true,
                        IsPieOfTheWeek = false,
                        ImageThumbnailUrl =
                            "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg",
                        LongDescription =
                            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                        AllergyInformation = ""
                    },
                    new Pie
                    {
                        Name = "Cranberry Pie",
                        Price = 17.95M,
                        ShortDescription = "A Christmas favorite",
                        Category = Categories["Seasonal pies"],
                        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg",
                        InStock = true,
                        IsPieOfTheWeek = false,
                        ImageThumbnailUrl =
                            "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg",
                        AllergyInformation = "",
                        LongDescription =
                            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies."
                    },
                    new Pie
                    {
                        Name = "Peach Pie",
                        Price = 15.95M,
                        ShortDescription = "Sweet as peach",
                        AllergyInformation = "",
                        Category = Categories["Fruit pies"],
                        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg",
                        InStock = false,
                        IsPieOfTheWeek = false,
                        ImageThumbnailUrl =
                            "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg",
                        LongDescription =
                            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies."
                    },
                    new Pie
                    {
                        Name = "Pumpkin Pie",
                        Price = 12.95M,
                        ShortDescription = "Our Halloween favorite",
                        Category = Categories["Seasonal pies"],
                        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
                        InStock = true,
                        IsPieOfTheWeek = true,
                        ImageThumbnailUrl =
                            "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
                        LongDescription =
                            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                        AllergyInformation = ""
                    },
                    new Pie
                    {
                        Name = "Rhubarb Pie",
                        Price = 15.95M,
                        ShortDescription = "My God, so sweet!",
                        Category = Categories["Fruit pies"],
                        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg",
                        InStock = true,
                        IsPieOfTheWeek = true,
                        ImageThumbnailUrl =
                            "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                        LongDescription =
                            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                        AllergyInformation = ""
                    },
                    new Pie
                    {
                        Name = "Strawberry Pie",
                        Price = 15.95M,
                        ShortDescription = "Our delicious strawberry pie!",
                        Category = Categories["Fruit pies"],
                        ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                        InStock = true,
                        IsPieOfTheWeek = false,
                        ImageThumbnailUrl =
                            "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                        LongDescription =
                            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                        AllergyInformation = ""
                    },
                    new Pie
                    {
                        Name = "Strawberry Cheese Cake",
                        Price = 18.95M,
                        ShortDescription = "You'll love it!",
                        Category = Categories["Cheese cakes"],
                        ImageUrl =
                            "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg",
                        InStock = false,
                        IsPieOfTheWeek = false,
                        ImageThumbnailUrl =
                            "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg",
                        LongDescription =
                            "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                        AllergyInformation = ""
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> _categories;

        public static Dictionary<string, Category> Categories // key: CategoryName, value: Category obj
        {
            get
            {
                if (_categories != null) return _categories;

                var genresList = new Category[]
                {
                    new Category {CategoryName = "Fruit pies"},
                    new Category {CategoryName = "Cheese cakes"},
                    new Category {CategoryName = "Seasonal pies"}
                };

                _categories = new Dictionary<string, Category>();

                foreach (Category genre in genresList)
                {
                    _categories.Add(genre.CategoryName, genre);
                }

                return _categories;
            }
        }
    }
}