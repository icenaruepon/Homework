using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            //รับค่า
            Console.Write("Input 6 digit password : ");
            int pass = int.Parse(Console.ReadLine());
            Console.Write("Input your agency : ");
            string agency = Console.ReadLine();
            
            //แยกหลังของรหัส
            int d6 = pass/100000;                                                                   //หลักแสน
            int d5 = (pass / 10000) - (d6 * 10);                                                    //หลักหมื่น
            int d4 = (pass / 1000) - (d5 * 10) - (d6 * 100);                                        //หลักพัน
            int d3 = (pass / 100) - (d4 * 10) - (d5 * 100) - (d6 * 1000);                           //หลักร้อย
            int d2 = (pass / 10) - (d3 * 10) - (d4 * 100) - (d5 * 1000) - (d6 * 10000);             //หลักสิบ
            int d1 = pass - (d6 * 100000) - (d5 * 10000) - (d4 * 1000) - (d3 * 100) - (d2 * 10);    //หลักหน่วย

            //สังกัด
            if (agency == "CIA") 
            {
                bool check = (d1 % 3 == 0) && (d2!=1 && d2 != 3 && d2 != 5) && (d4>=6 && d4!=8);
                Console.WriteLine("Result : {0}", check);
            }
            else if (agency == "FBI")
            {
                bool check = (d6 >= 4 && d6 <= 7) && (d3 != 6 && d3 % 2 == 0) && (d5 % 2 == 1);
                Console.WriteLine("Result : {0}", check);
            }
            else if (agency == "NSA")
            {
                bool check = (30 % d1 == 0) && (d3 % 3 == 0 && d3 % 2 == 1) && (d1 == 7 || d2 == 7 || d3 == 7 || d4 == 7 || d5 == 7 || d6 == 7);
                Console.WriteLine("Result : {0}", check);
            }
            else
            {
                Console.WriteLine("Status : Enermy Alert!!");
            }
            




        }
    }
}
