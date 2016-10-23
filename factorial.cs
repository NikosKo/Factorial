using System;
namespace work
{
	class nikos
	{
		//εδω υπολογιζω το παραγοντικο με χρηση του if//
		public int factorial(int x)
		{
			int sum=1;
			for(int i=x;i>=1;i--)
			{
				sum=sum*i;
				
			}
			return sum;
			
			
			
		}
		//εδω υπολογιζω το παραγοντικο με χρηση του while//
		public int factorial1(int y)
		{
			int sum1=1;
			int j=y;
			while(j>=1)
			{
				sum1=sum1*j;
				j=j-1;
				
			}
			return sum1;
			
			
		}
		
		
		static void Main(string[]args)
		{
			int a;
			int b;
			Console.WriteLine("Factorial with for---Enter number: ");
			a=Convert.ToInt32(Console.ReadLine());//εδω ο χρηστης εισαγει το νουμερο για το οποιο θα βρει το παραγοντικο την εντολη τη βρηκα στο http://stackoverflow.com/questions/24443827/reading-an-integer-from-user-input//
			nikos nikosobj=new nikos();
			nikosobj.factorial(a);
			Console.WriteLine("Factorial is " + nikosobj.factorial(a));
			
			Console.WriteLine("Factorial with while---Enter number: ");
			b=Convert.ToInt32(Console.ReadLine());
			nikosobj.factorial1(b);
			Console.WriteLine("Factorial is " + nikosobj.factorial1(b));
			Console.WriteLine("press any key to exit programm");
			Console.ReadLine();
			
			
			
		}
		
		
	}
	
	
}

