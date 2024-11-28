using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay2
{
    internal class BankAccount
    {
       private int ID;
       public  string Name;
       private string Password;//security purpose
       private int balance;//validation

        //#region constructor
        ////constructor chaining
        //public BankAccount():this(1,"xipher","123",2000)
        //{
        //    Console.WriteLine("Default Constructor");
        //}
        //public BankAccount(int balance):this(1, "xipher", "123",balance)
        //{
        //    Console.WriteLine("Constructor take Balance only");
        //}
        //#endregion
        //public BankAccount(int id, string name, string password, int balance) 
        //{
        //    SetBalance(balance);
        //}

        public int Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if ( value> 5000)
                {
                    balance = value;
                }
                else
                {

                    Console.WriteLine($"{value} invalid, must be more than 5000");

                }
            }
        }


        ////set ID
        //public void setID(int ID)
        //{
        //    ID = ID;
        //}

        //set balance 
       // public void SetBalance(int amount)
       // {
       //     if(amount >= 1000)
       //     {
       //         balance = amount;
       //     }
       //     else
       //     {
                
       //             Console.WriteLine("the less value have to be equals or more than 1000 riyals!");
           
       //     }

       // }
        
       // //get balance getway
       //public int GetBalance()
       // {
            
       //     return balance; 
       // }
       // public void WithDraw(int amount)
       // {
       //     if(amount < balance && amount > 1000)
       //     {
       //         balance = balance - amount;
       //     }
       //     else 
       //     {
                
       //         Console.WriteLine("You don't have enough money!");
       //     }

       // }
    }
}
