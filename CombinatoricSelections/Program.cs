using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatoricSelections
{
	public class pair<T1, T2>
	{
		public T1 v1;
		public T2 v2;
	}
	public class quantList : Dictionary<int, int>
	{
		public void Add(int n)
		{
			if (!base.Keys.Contains(n))
				base[n] = 0;
			base[n]++;
		}
		public void Add(int n, int q)
		{
			if (!base.Keys.Contains(n))
				base[n] = 0;
			base[n] += q;
		}
		public void AddRange(quantList q)
		{
			foreach (KeyValuePair<int, int> kvp in q)
			{
				Add(kvp.Key, kvp.Value);
			}
		}
	}
	class multSeq : quantList
	{
		public multSeq(int low, int high) : base()
		{
			for (int i = low; i <= high; i++)
			{
				Add(i);
			}
		}

		public static void cancelOutAndFactor(multSeq s1, multSeq s2)
		{

			multSeq.Enumerator e1 = s1.GetEnumerator();
			multSeq.Enumerator e2 = s2.GetEnumerator();
			while (true)
			{
				if(e1.Current.Key < e2.Current.Key)

			}
		}
		
	}
	class Program
	{
		static void Main(string[] args)
		{
		}
	}
}
