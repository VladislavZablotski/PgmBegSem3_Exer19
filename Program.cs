Console.WriteLine("Введите число");
string num = Console.ReadLine();
bool palindrome = true;

for (int i=0; i<num.Length/2;i++)
{
    if(num[i]==num[num.Length-1-i]) palindrome=true;
    else 
    {
        palindrome=false;
        break;
    }
}

if (palindrome==true) Console.WriteLine("Палиндром!");
else Console.WriteLine("Не палиндром!");

