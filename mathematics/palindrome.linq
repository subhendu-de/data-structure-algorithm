<Query Kind="Statements" />

// Check Palindrome Number
// take the number
// divide the number by 10 to get the digit from right to left
// Use the formula palindrome = [palindrome * 10 + remainder]

int n = 121, temp = n, remainder = 0, palindrome = 0;

do
{
	remainder = n % 10;
	n = n / 10;
	palindrome = palindrome * 10 + remainder;
	
} while(n != 0);

if(temp == palindrome)
	Console.WriteLine("Yes");
else
	Console.WriteLine("No");

