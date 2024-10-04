string? input;
bool isValidValue = false;
Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do
{
#pragma warning disable CS8602 // Dereference of a possibly null reference.
    input = Console.ReadLine().Trim().ToLower();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    switch (input)
    {
        case "administrator":
            Console.WriteLine($"Your input value ({input}) has been accepted.");
            isValidValue = true;
            break;
        case "manager":
            Console.WriteLine($"Your input value ({input}) has been accepted.");
            isValidValue = true;
            break;
        case "user":
            Console.WriteLine($"Your input value ({input}) has been accepted.");
            isValidValue = true;
            break;
        default:
            Console.WriteLine($"The role name that you entered, \"{input}\" is not valid. Enter your role name (Administrator, Manager, or User)");
            break;
    }
} while (!isValidValue);
