using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Programming_Problem_Set_1.Model
{
    internal class Inside
    {

        public Boolean inside (int point_x1, int point_y1, int point_x2, int point_y2, int x, int y)
            

        {
            int x1 = point_x1;
            int y1 = point_y1;
            int x2 = point_x2;
            int y2 = point_y2;
            int a = x;
            int b = y;
            Boolean c = true;
            
            
           if (a>x1 && a<x2 && b > y1 && b<y2)
             {

                c = true;
                Console.WriteLine("True");
             }
           else
             {
                c= false;
                Console.WriteLine("False");
            }
            return c;
            

                
            }


           

        }

    }

