using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class City
    {
        private string name;
        private int code;
        private int displayorder;

        private static int nextCityCode=1;

        public City(string name,int displayorder)
        {
            this.name = name;
            this.displayorder = displayorder;
            this.code = nextCityCode;
            nextCityCode++;
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
            set { DisplayOrder = value; }

        } 
    }
}