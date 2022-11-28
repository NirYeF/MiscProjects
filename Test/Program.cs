// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
#nullable disable
class Program
{
    static List<City> cities = new List<City>();
    static List<Street> streets = new List<Street>();
    static void Main(string[] args)
    {
        int num;
        while (true)
        {
            Console.WriteLine("Choose one of the following options\n 1 - Insert city\n 2 - Insert street\n 3 - Show all cities\n 4 - Show all streets\n 5 - Exit");
            num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                default:
                    Console.WriteLine("No valid response, please try again");
                    break;
                case 1:
                    InsertCity();
                    break;

                case 2:
                    InsertStreet();
                    break;

                case 3:
                    PrintCity();
                    break;

                case 4:
                    PrintStreets();
                    break;

                case 5:
                    Environment.Exit(0);
                    break;
            }
        }

    }
    static void InsertCity()
    {
        string city_name;
        int city_displayorder;
        do
        {
            Console.WriteLine("If the following city name and display order already exist, insert them again");
            Console.WriteLine("Choose the name of the city you want to insert");
            city_name = Console.ReadLine();
            Console.WriteLine("Choose the display order of the city you want to inesrt");
            city_displayorder = Convert.ToInt32(Console.ReadLine());
        } while (cities.Any(c => String.Equals(c.Name,city_name,StringComparison.OrdinalIgnoreCase) || c.DisplayOrder == city_displayorder));
        cities.Add(new City(city_name, city_displayorder));
        Console.WriteLine("City added with success");
        Console.WriteLine("The name of the city is:{0}\n The display order number of the city is:{1}", city_name,city_displayorder);
    }
    static void InsertStreet()
    {
        string street_name;
        int street_displayorder;
        int city_code;
        bool flag = true;
        do {
            Console.WriteLine("If the following street name and display order already exist, insert them again");
            Console.WriteLine("Choose the name of the street that you wanna insert");
            street_name = Console.ReadLine();
            Console.WriteLine("Choose the display order of the city you want to insert");
            street_displayorder = Convert.ToInt32(Console.ReadLine());
        } while (streets.Any(s => String.Equals(s.Name, street_name, StringComparison.OrdinalIgnoreCase) || s.DisplayOrder == street_displayorder));
          Console.WriteLine("Insert the code of the city which contains the street");
          city_code = Convert.ToInt32(Console.ReadLine());
        foreach (City c in cities)
        {
            if (city_code == c.Code)
            {
                streets.Add(new Street(street_name, street_displayorder, city_code));
                flag = false;
                break;
            }
        }
        if (!flag)
            Console.WriteLine("No matching city code exists");

    }
    static void PrintCity()
    {
        cities.Sort((c1, c2) => c1.DisplayOrder.CompareTo(c2.DisplayOrder));
        foreach(City c in cities)
        {
            Console.WriteLine("{0}. City:{1},City code:{2}",c.DisplayOrder,c.Name,c.Code);
        }

    }
    static void PrintStreets()
    {
        string city_name;
        int city_code = 0;
        streets.Sort((s1, s2) => s1.DisplayOrder.CompareTo(s2.DisplayOrder));
        Console.WriteLine("Enter the city name that you want to show the street names for");
        city_name = Console.ReadLine();
        foreach(City c in cities)
        {
            if (String.Equals(c.Name, city_name, StringComparison.OrdinalIgnoreCase))
            {
                city_code = c.Code;
                break;
            }
        }
        if (city_code == 0)
        {
            Console.WriteLine("There is no such city");
            return;
        }
        foreach(Street s in streets)
        {
            if(city_code == s.City_Code)
                Console.WriteLine("{0}. Street:{1},Street code:{2}", s.DisplayOrder, s.Name, s.Code);
        }

    }
       
}