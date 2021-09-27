using System;
using System.Collections;
using System.Collections.Generic;

namespace Hadamard
{
	public class Hadamard
	{
		public int Size { get; set;}
		public List<List<int>> HadamardMatrix { get; set; }
		ArrayList hMatrixRows { get; set; }

		public Hadamard(int size = 2)
        {
			Size = size;
			HadamardMatrix = generateHMatrix(Size);
		}

		private List<List<int>> generateHMatrix(int n)
		{
			List<List<int>> hMatrix = new List<List<int>>();
			for (int i = 0; i < n; i++) {
				hMatrix.Add(new List<int>());
				for (int j = 0; j < n; j++)
				{
					hMatrix[i].Add(0);
				}
			}
			
			hMatrix[0][0] = 1;
			for (int i1 = 1; i1 < n; i1+=i1) {
				for (int i2 = 0; i2 < i1; i2++){
					for (int i3 = 0; i3 < i1; i3++)
					{
						hMatrix[i2 + i1][i3] = hMatrix[i2][i3];
						hMatrix[i2][i3 + i1] = hMatrix[i2][i3];
						hMatrix[i2 + i1][i3 + i1] = -hMatrix[i2][i3];
					}
				}
			}
			return hMatrix;
        }
		private void printHadamardMatrix(List<List<int>> hadamardMatrix)
		{
			Console.WriteLine($"Inside the printer: Size: {hadamardMatrix.Count}");
			for (int i=0;i< hadamardMatrix.Count; i++)
			{
				for (int j=0; j< hadamardMatrix[i].Count; j++)
				{
					Console.Write(hadamardMatrix[i][j] + "\t");
				}
				Console.WriteLine();
			}
		}

		public void Run(List<List<int>> hadamardMatrix)
		{
			Console.WriteLine($"You've selected a Hadamard Matrix size of: {Size}");
			printHadamardMatrix(hadamardMatrix);
		}
	}
}