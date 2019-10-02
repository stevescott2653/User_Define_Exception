using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Define_Exception
{
    public class ProgramInvalidAgeException : Exception
    {
        public ProgramInvalidAgeException(String message)
            : base(message)
        {

        }
    }

    public class TestUserDefinedException
    {
        static void validate(int age)
        {
            if (age < 18)
            {
                throw new ProgramInvalidAgeException("Sorry, Age must be greater than 18");
            }
        }

        public static void Main(string[] args)
        {
            try
            {
                validate(12);
            }
            catch (ProgramInvalidAgeException e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Rest of the code");
        }
    }
}
