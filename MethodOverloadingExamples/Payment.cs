using System;
/*3. Create a class Payment having a static method payBill
If you pay the bill by cash you are not eligible for any discount  , method payBill(double amt)
If you pay by a  mode you get 15% discount on the bill  , method  payBill(double amt, String mode)
*/

namespace MethodOverloadingExamples
{
    public class Payment
    {
       
         public void PayBill(double amount)
        {
            Console.WriteLine("You are not eligible for any discount by Cash Mode");
            Console.WriteLine("Your Total Bill:"+amount);
            
        }
        public void PayBill(double amount,string mode)
        {
            
            amount = amount - (amount * 15) / 100;
            Console.WriteLine("Your Total Bill:" + amount);

        }


    }
}
