using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges
{
    /*
        Challenge:
        User should be able to create only 10 instance of the specified class.
        If User tries to create more than that then an exception should be thrown.

        Client Code:
        for(int i=0; i<20;i++)
            {
                LimitClassInstance myObj = new LimitClassInstance();
            }
    */

    public class LimitClassInstance
    {
        

        private static int _instanceCount = 0; //creating a static counter to count number of instance.

        public LimitClassInstance()
        {
            if (_instanceCount < 10)
            {
                _instanceCount++;
                Console.WriteLine("Number of class created: {0}", _instanceCount);
            }

            else
            {
                throw new Exception("Exceeded class instantiation limit");
            }
        }
    }
}
/*
    Note:
    The keyword "static" means that only one instance of a given variable exists for a class. 
    Static variables are used to define constants because their values can be retrieved by 
    invoking the class without creating an instance of it.
*/
