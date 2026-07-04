const double miles_to_kilometers_multiplier = 1.60934;
const double kilometers_to_miles_multiplier = 0.621371;

double get_conversion_multiplier()
{
    while (true)
    {
        Console.WriteLine();
        Console.WriteLine("Select a Conversion:");
        Console.WriteLine("1. Miles to Kilomters");
        Console.WriteLine("2. Kilometers to Miles");
        Console.WriteLine();
        string selected_conversion = Console.ReadLine();

        if (selected_conversion == "1")
        {
            double conversion_multiplier = miles_to_kilometers_multiplier;
            return conversion_multiplier;
        } 
        else if (selected_conversion == "2")
        {
            double conversion_multiplier = kilometers_to_miles_multiplier;
            return conversion_multiplier;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Invalid input. Please enter 1 or 2.");
            Console.WriteLine();
            continue;
        }
    }
}

double get_user_num()
{
    while (true) {
        double conversion_multiplier = get_conversion_multiplier();
        
        Console.WriteLine();
        Console.WriteLine("Enter a number to convert:");
        Console.WriteLine();
        string user_num = Console.ReadLine();
            
        if (user_num.Contains('.')) {    
            string[] user_num_parts = user_num.Split('.');

            bool is_valid_number = user_num_parts.Length == 2 && user_num_parts[0].All(char.IsDigit) && user_num_parts[1].All(char.IsDigit);

            if (!is_valid_number || user_num == "") {
                Console.WriteLine();
                Console.WriteLine("You need to enter a valid number!");
                Console.WriteLine();
                continue;
            }
        }
        else
        {
            bool is_valid_number = user_num.All(char.IsDigit);
            
            if (!is_valid_number || user_num == "")
            {
                Console.WriteLine();
                Console.WriteLine("You need to enter a valid number!");
                Console.WriteLine();
                continue;
            }
            
        }

        double converted_value = Convert.ToDouble(user_num) * conversion_multiplier;
        return converted_value;
    }
}

while (true) {
    double converted_value = get_user_num();
    Console.WriteLine($"Output: {converted_value}");
    Console.WriteLine("Would you like to convert another unit? (Y/n)");
    Console.WriteLine();
    string again = Console.ReadLine();

    if (again.ToUpper() == "Y")
    {
        Console.Clear();
        continue;
    }
    else
    {
        break;
    }
}