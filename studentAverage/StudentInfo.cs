using System;
using System.Collections.Generic;
using System.Collections;
using System.Xml.Serialization;

namespace studentAverage
{
    class StudentInfo : IStdntAvg
    {
        public string getMax()
        {
            
            int n, i, Max;
            int[] ar = new int[] {10,50,99,99,100 };
            Console.WriteLine("enter the number");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("eneter the Array elements");
            for ( i = 0; i < n; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            Max = ar[0];
            for ( i = 0; i < n; i++)
            {
                Max = ar[i];
            }
            return Max.ToString();
        }

        public string getName(string name)
        {
            return "Hello Mr/Ms " + name;
        }

        public string getResult(int sid, string sName, int m1, int m2, int m3, int m4)
        {
            double avg = (m1 + m2 + m3 + m4) / 4.0;
            if (avg < 50)
            {
                return "Hello Mr/Ms " + sName + " you have failed the exam";
            }
            else
                return "Hello Mr/Ms " + sName + " you have passed the exam";
        }

        public int[] sort(int[] ar)
        {
            Array.Sort(ar);
            return ar;
        }
    
    }

}
