using System;

namespace InterfaceSegregationPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I: Interface Segregation Principle (ISP)!");
            Console.ReadLine();
        }
    }
}


/*I in the SOLID is acronym for Interface Segregation Principle.

1. The interface-segregation principle(ISP) states that "no client should be 
   forced to depend on methods it does not use".
2. Which means, Instead of one fat interface many small interfaces are 
   preferred based on groups of methods with each one serving one submodule.*/


/*CASE Study

Problem
• As we all know Xerox Corporation manufactures printer systems. In their 
  development process of new systems Xerox had created a new printer system
  that could perform a variety of tasks such as stapling and faxing along 
  with the regular printing task. 

• The software for this system was created from the ground up. 

• As the software grew for Xerox, making modifications became more and 
  more difficult so that even the smallest change would take a redeployment 
  cycle of an hour, which made development nearly impossible.
 
• The design problem was that a single Job class was used by almost all of the 
  tasks. Whenever a print job or a stapling job needed to be performed, a call 
  was made to the Job class. 

• This resulted in a 'fat' class with multitudes of methods specific to a 
  variety of different clients. 

Because of this design, a staple job would know about all the methods of the 
print job, even though there was no use for them.
 
Solution
• To overcome this problem Robert C Martin suggested a solution which is 
  called the Interface Segregation Principle. 

• Which means, Instead of one fat interface many small interfaces are preferred 
  based on groups of methods with each one serving one submodule.*/