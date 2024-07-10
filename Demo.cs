using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Demo1
{
    internal class Demo
    {
        public static int staticCount;
        public  int intCount; 

        public void LocalVariableDemo()
        {
            int count=200; //No Default value --Value assigned before using them
            Console.WriteLine("Counts : {0}", count);
        }
        public void Print()
        {
           
            staticCount++;
            intCount++;
            Console.WriteLine("Static : {0}   Integer :{1} ",staticCount, intCount);

        }
        public void PrintDemo()
        {
            staticCount++;
            intCount++;
            Console.WriteLine("Static : {0}   Integer :{1} ", staticCount, intCount);
        }
    }
}
