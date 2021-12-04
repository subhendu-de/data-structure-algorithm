<Query Kind="Statements" />

// Number of digits ina number
// take the number
// divide the numebr by 10 til the quotient is 0

int n = 1234567890, counter = 0;

do
{
	n = n / 10;
	counter++;
	
} while(n != 0);

Console.WriteLine(counter);