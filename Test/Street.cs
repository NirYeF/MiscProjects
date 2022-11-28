using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Street
    {
        private string name;
        private int code;
        private int displayorder;
        private int city_code;
        private static int nextStreetCode = 100;
        public Street(string name, int displayorder, int city_code)
        {
            this.name = name;
            this.displayorder = displayorder;
            this.code = nextStreetCode;
            nextStreetCode++;
            this.city_code = city_code;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Code
        {
            get { return code; }
        }
        public int DisplayOrder
        {
            get { return displayorder; }
            set { displayorder = value; }
        }
        public int City_Code
        {
          get { return city_code; }
          set { city_code = value; }
        }

    }
}
