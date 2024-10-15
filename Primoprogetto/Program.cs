using System;

class Program
{
    static void Main(string[] args)
    {
		#if DEBUG
			for (int index = 1; index <= 10; index++)
			{
				Console.WriteLine(index);
			}
		#endif
	
		#if RELEASE
			for (int index = 1; index <= 20; index++)
			{
				Console.WriteLine(index);
			}
		#endif
    }
}

