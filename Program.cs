using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllPossibleCompositeNums
{
	// Given a set of prime numbers return all possible composite numbers from the given set
	
	class Program
	{
		static List<int> AllPossibleCompositeNums(int[] set, int set_size)
		{
			uint pow_set_size = (uint)Math.Pow(2, set_size);
			int counter, j;
			List<int> list = new List<int>();
			for (counter = 0; counter <pow_set_size; counter++)
			{
				int value = 1;
				for (j = 0; j < set_size; j++)
				{
					if ((counter & (1 << j)) > 0) // 1 left shift by j number of times
					{
						value *= set[j];						
					}
				}
				list.Add(value);				
			}
			return list;
		}
		
		public static void Main()
		{
			int[] set = { 2,3,5 };
			List<int> lst =  AllPossibleCompositeNums(set, 3);
			foreach(int value in lst)
            {
				Console.Write(value + " ");
            }
			Console.ReadLine();
		}
	}




}
