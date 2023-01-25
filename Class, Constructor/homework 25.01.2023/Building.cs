using System;
using System.Collections.Generic;
using System.Text;

namespace homework_25._01._2023
{
    public class Building
    {
        public string name;
        public int height;
        public int area;
        public string adress;

        public Building(string name, int height, int area)
        {
            this.name = name;
            this.height = height;
            this.area = area;
        }
        public int GetVolume()
        {
            int volume = height * area;
            return volume;
        }

        public string GetInfo()
        {
            return $" name--{name}--\n height--{height}--\n area--{area}--\n volume--{GetVolume()}--\n";
        }
    }
   
}
