using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsLibrary
{
    public class DemoCode
    {
        public int GrandParent(int position)
        {
            int output = 0;
            Console.WriteLine("Opening Db connection");

            try
            {
                output = Parent(position);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("wrong info " + ex);
            }
            catch(Exception ex)
            {
                //Do some logging
                throw new Exception("You passed in bad data", ex);
            }
            finally
            {
                Console.WriteLine($"Closing Db connection");
            }

            return output;
        }

        public int Parent(int position)
        {
            return GetNumber(position);
        }

        public int GetNumber(int position)
        {
            int result = 0;
            //try
            //{
                int[] numbers = new int[] { 1, 2, 3, 4 };
                result =  numbers[position];
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //    Console.WriteLine(ex.StackTrace);
            //}

            return result;
        }
    }
}
