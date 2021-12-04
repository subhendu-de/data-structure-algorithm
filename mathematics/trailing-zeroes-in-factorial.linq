<Query Kind="Statements" />

// Trailing Zeroes in Factorial
// take the number
// calculate factorial
// calculate trailing 0's

int n = 20;
long factorial = CalculateFactorial(n);
int numberofTrailingZeroes = GetTrailingZeroes(factorial);
Console.WriteLine("{0}, {1}", factorial, numberofTrailingZeroes);

long CalculateFactorial(int n)
{
	if(n==0)
	{
		return 1;
	}
	else
	{
		return n * CalculateFactorial(n-1);
	}
}

int GetTrailingZeroes(long n)
{
	int counter = 0;
	long remainder = 0;
	do
	{
		remainder = n % 10;	
		n = n / 10;	
		counter++;
	} while(remainder == 0);
	
	return (counter - 1);
}