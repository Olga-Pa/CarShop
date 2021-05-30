using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {

        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car> {
                    new Car {
                        name = "Tesla Model S",
                        shortDesc = "The Tesla Model S is an all-electric five-door liftback sedan",
                        longDesc = "The Model S is notable for being designed from the ground up with an electric powertrain in mind,[82] unlike other electric vehicles where the manufacturer has simply swapped out or supplanted an internal combustion engine with an electric motor.[83][84][85] As a result, the Model S is able to offer features such as a front trunk in addition to a large rear trunk space and an enlarged front crumple zone compared to the typical combustion engine powered vehicle.[86].",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                         name = "Ford Fiesta",
                        shortDesc = "The Ford Fiesta is a supermini marketed by Ford since 1976 over seven generations.",
                        longDesc = "The Fiesta was an all new car in the supermini segment, and was the smallest car yet made by Ford. Development targets indicated a production cost US$100 less than the current Escort. The car was to have a wheelbase longer than that of the Fiat 127, but with overall length shorter than that of Ford's Escort. The final proposal was developed by Tom Tjaarda at Ghia, overseen by Ford of Europe's then chief stylist Uwe Bahnsen. The project was approved for production in late 1973, with Ford's engineering centres in Cologne and Dunton (Essex) collaborating.",
                        img = "/img/fiesta.jpg",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {

                        name = "BMW M3",
                        shortDesc = "The BMW M3 is a high-performance version of the BMW 3 Series, developed by BMW's in-house motorsport division, BMW M GmbH. ",
                        longDesc = "The first BMW M3 was based on the E30 3 Series and was intended to be a homologation special to satisfy the Deutsche Tourenwagen Meisterschaft and Group A Touring rules, which required a total of 5,000 cars to be built.[4] It was presented to the public at the 1985 Frankfurt Motor Show, and began production from March 1986 to June 1991.[5][6][7] The E30 M3 was mainly produced in the coupé body style, but limited volumes of convertibles were also produced.[8]",
                        img = "/img/m3.jpg",
                        price = 65000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Mercedes C class",
                        shortDesc = "The Mercedes-Benz C-Class is a series of compact executive cars produced by Daimler AG.",
                        longDesc = "Introduced in 1993 as a replacement for the 190 (W201) range, the C-Class was the smallest model in the marque's line-up until the W168 A-Class arrived in 1997. The C-Class is built at Mercedes-Benz factories in Sindelfingen and Bremen, Germany as well as numerous satellite factories in other countries. The first C-Class (W202) sedan was produced on 1 June 1993 and the first second generation (W203) rolled off the assembly line on 18 July 2000. The C-Class has been available with a 4MATIC (i.e., four-wheel drive) option since 2002. The third generation (W204) was launched in 2007 while the latest generation C-Class (W205) came out in 2014.",
                        img = "/img/mercedes.jpg",
                        price = 40000,
                        isFavourite = false,
                        available = false,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Nissan Leaf",
                        shortDesc = "The Nissan Leaf, stylised as LEAF, is a compact five-door hatchback battery electric vehicle (BEV) manufactured by Nissan. It was introduced in Japan and the United States in December 2010, and it is currently in its second generation, introduced in Japan in October 2017.",
                        longDesc = "Among other awards and recognition, the Leaf has won the 2010 Green Car Vision Award, the 2011 European Car of the Year, the 2011 World Car of the Year, and the 2011–2012 Car of the Year Japan.",
                        img = "/img/nissan.jpg",
                        price = 14000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
