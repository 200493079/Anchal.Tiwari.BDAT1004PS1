using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Programming_Problem_Set_1.Model
{
    internal class trianglearea
    {
        public double areaoftriangle (int side_a, int side_b, int side_c)

        {

            float s;
            float temp1;
            float temp2;double final_area;
            s = (side_a+side_b+side_c)/ 2;
            temp1 = (s - side_a) * (s - side_b) * (s - side_c);
            temp2 = s * temp1;
            final_area= Math.Sqrt(temp2);

            Console.WriteLine($"Arae of triagle using Heron's Formula is={final_area}");
            return (final_area);
        }

       

    }
}
