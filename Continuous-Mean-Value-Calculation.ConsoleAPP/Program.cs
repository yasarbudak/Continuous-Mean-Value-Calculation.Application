int mean = 0;
int count = 0;

while (true)
{
  Console.Write("Enter a value (Press 'x' to exit): ");
  string inputValue = Console.ReadLine();

  if (inputValue.ToLower() == "x")
  {
    break;
  }

  if (int.TryParse(inputValue, out int value))
  {
    mean = (mean * count + value) / count + 1;
    count++;

        Console.WriteLine("New mean: " + mean);
    }
  else
  {
    Console.WriteLine("You have to enter a numeric value or press 'x' to exit.");
  }
}