
using bank_login_uptade.helper;

string name = "Tofiq";
string banKNum = "1234567890";
string banKPass = "0123";
int maxMoney = 1500;
int minMoney = 900;
int accaount = 500;
again:
int bankPass = Convert.ToInt32(banKPass);
Console.WriteLine("Kart nomresini daxil edin");
var num = Console.ReadLine();
Console.WriteLine("sifreni daxil edin");
var pass = Console.ReadLine();
if (num == banKNum && pass == banKPass)
{
    Console.WriteLine(name + " " + "Xos geldin");
before:
    Console.WriteLine("Emeliyyatlar :");
    Console.WriteLine(" 1. balansinizdaki hesab");
    Console.WriteLine(" 2. pulun daxil edilmesi");
    Console.WriteLine(" 3. pulun cixarilmasi ");
    Console.WriteLine(" 4. emeliyyatin legvi ");
    var numBer = Console.ReadLine();
    LoginSwitch loginSwitch = new LoginSwitch();
    switch (Convert.ToInt32(numBer))
    {
        case 1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("hesabiniz:" + accaount + "AZN");
            Console.ForegroundColor = ConsoleColor.White;
            goto before;
            break;
        case 2:
            loginSwitch.addMoney(maxMoney, accaount);
            goto before;
            break;
        case 3:
            loginSwitch.removeMoney(minMoney, accaount);
            goto before;
            break;
        case 4:
            Console.WriteLine(name + " " + "Karti goturmeyi unutma!! Bizi secdiyin ucun tesekkur edirik. KAPITAL BANK :)");
            goto again;
            break;
        default:
            Console.WriteLine("reqemi duzgun daxil edin");
            break;
    }
}
else if (num == "" && pass == "")
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("zehmet olmasa melumatlari daxil edin");
    Console.ForegroundColor = ConsoleColor.White;
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("daxil ola bilmediniz.");
    Console.ForegroundColor = ConsoleColor.White;
    if (num != banKNum)
    {
        Console.WriteLine("kard nomresini duzgun daxil edin");
    }
    else if (pass != banKPass)
    {
        Console.WriteLine("sifreni duzgun daxil edin");
    }
}
