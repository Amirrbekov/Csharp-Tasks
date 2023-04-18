string username = "admin";
string password = "123";
bool k = false;

do
{
    Console.Write("Please Enter Your Username: ");
    string yusername = Console.ReadLine();
    Console.Write("Please Enter Your Password: ");
    string ypassword = Console.ReadLine();
    if (yusername == username && ypassword == password) 
    {
        Console.WriteLine("Correct");
        k = true; 
    }
    else Console.WriteLine("Username or password wrong");
} while (!k);