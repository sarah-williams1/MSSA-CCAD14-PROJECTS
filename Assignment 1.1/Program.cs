/* ASSIGNMENT 1.1.1: This console app will store my name, age, and addresss in string variables and print them on teh console.
 * User will be prompted to in put the information
 */

string myFirstAndLastName;
string myAddress;
int myAge;

Console.WriteLine("Hello, what is your first and last name?");
myFirstAndLastName = Console.ReadLine();

Console.WriteLine("Hello Overlord " + myFirstAndLastName + ", how old are you?");
myAge = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Thank you. Can I have your address please?");
myAddress = Console.ReadLine();

Console.WriteLine("Thank you!");

/* ASSIGNMENT 1.1.2-4: This part will include basic datatypes like int, float, decimal, double and print the min and max values.
 * The program will add two numbers and divide two numbers.
 */

int monthsInAYear = 12;
float hourlyWage = 9.2F;
decimal annualSalary = 15000;
double chickensEatenPerDay = 12.80;

// Converting a float to a decimal.
decimal decimalHourlyWage = (decimal)hourlyWage;
decimal divisionAnswer = annualSalary / decimalHourlyWage;
Console.WriteLine(divisionAnswer);

// Adding a double and an integer.
Console.WriteLine(chickensEatenPerDay + monthsInAYear);


