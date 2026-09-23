





Console.Write("What was the round trip in miles?");
int roundTripMiles = Convert.ToInt32(Console.ReadLine());

Console.Write("What was the miles per gallon of the car you are using?");
int milesPerGallon = Convert.ToInt32(Console.ReadLine() );

Console.Write("What is the cost per gallon?");
double gasPrice = Convert.ToDouble(Console.ReadLine());

//do the math

double gallonsNeeded = roundTripMiles / (double)milesPerGallon;

double fuelCost = gallonsNeeded * gasPrice;

//do the output.
System.Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("Fuel Cost: " + fuelCost.ToString("C"));

Console.Write("How Many people are going to pizza party?");
int people=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many pizzas?");
int pizzas = convert





