using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_login_uptade.helper
{
    public class LoginSwitch
    {
        public void addMoney(int maxMoney, int accaount)
        {
            Console.Write("meblegi daxil edin:");
            var userMoney = Console.ReadLine();
            int userMoneyInt = Convert.ToInt32(userMoney);
            if (userMoneyInt <= maxMoney)
            {
                int result = accaount + userMoneyInt;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hesabdaki mebleg: " + result + "AZN");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Emeliyyat yanlisdir");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public void removeMoney(int minMoney, int accaount)
        {
            Console.Write("cixarisin miqdari:");
            var userMoney = Console.ReadLine();
            int userMoneyInt = Convert.ToInt32(userMoney);
            if (userMoneyInt <= minMoney && userMoneyInt <= accaount)
            {
                int result = accaount - userMoneyInt;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hesabdaki mebleg: " + result + "AZN");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Emeliyyat yanlisdir");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }


    }
}


