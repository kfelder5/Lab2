Name:  Kingston Felder
Course: CSCI 1250, Section 002 
Assigment: Lab 02, Trip Caculator 
Date: September 22,2026
Description: Calculates the fuel,food,and work hours behind one road trip


Part 1 Caculating the fuel cost 


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
// Part 2 caculating the pizza needed 
Console.Write("How Many people are going to pizza party?");
int people = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many pizzas?");
int pizzas = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the cost per pizza?");
double pizzaPrice = Convert.ToDouble(Console.ReadLine());
const int slicesPerPizza=8;
int totalSlices = pizzas * slicesPerPizza;
double slicesPerPerson = (double)totalSlices/people;
double pizzaCost = pizzas * pizzaPrice;

System.Console.WriteLine("Total Slices:" + totalSlices);
System.Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F1"));
System.Console.WriteLine("Pizza cost: "+ pizzaCost.ToString("C"));
//Caculating gross pay,taxes,and take home pay
Console.Write("How many hours did you work this week?");
int hours = Convert.ToInt32(Console.ReadLine());

Console.Write("What is your hourly rate?");
double rate = Convert.ToDouble(Console.ReadLine());

const double taxRate = 0.18;
double grossPay = hours * rate;
double taxWithheld = grossPay * taxRate;
double takeHomePay = grossPay - taxWithheld;

Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
Console.WriteLine("Take home pay: " + takeHomePay.ToString("C"));
//caculate total trip cost and work hours needed 
double tripTotal = fuelCost + pizzaCost;
double costPerPerson = tripTotal / people;
double takeHomePayPerHour = takeHomePay / hours;
double hoursYouMustWork = costPerPerson / takeHomePayPerHour;

System.Console.WriteLine("Trip total: " + tripTotal.ToString("C"));
System.Console.WriteLine("Cost Per person: " + costPerPerson.ToString("C"));
System.Console.WriteLine("Take home pay per hour: " + takeHomePayPerHour.ToString("C"));
System.Console.WriteLine("Hours you must work to cover your share: " + hoursYouMustWork.ToString("F2"));






