bool accessAllowed;

string storedPassword = "qwerty";
string enteredPassword = Console.ReadLine();

if (enteredPassword == storedPassword)
{
    accessAllowed = true;
}
else
{
    accessAllowed = false;
}

accessAllowed = storedPassword == enteredPassword ? true : false;

Console.WriteLine(accessAllowed);
Console.ReadLine(); 

int x = 5; // just a comment to test git changes

