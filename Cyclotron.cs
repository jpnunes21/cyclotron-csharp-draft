using System;
namespace CyclotronFunction;

public class Cyclotron
{
    public List<int> matrix = new();
    public string particle = "";
    public int matrixSize = 0;
    public void PrintMatrix()
    {
        for (var index = 0; index < matrixSize; index++)
        {
            if (index < matrixSize)
            matrix.Add(1);
        }

        for (var index = 0; index < matrix.Count; index++)
        {
            Console.WriteLine(String.Join(", ", matrix.ToArray()));
        }
    }

    public void GetParticleFirstLetter()
    {
        while(particle != "e" && particle != "p" && particle != "n")
        {
            Console.WriteLine("Write the first letter of the particle name. Type e for electron, p for proton, or n for neutron.");
            
            string? input = Console.ReadLine();

            particle = input;
        }
    }

    public void GetMatrixLength()
    {
        while(matrixSize == 0 || matrixSize < 0)
        {
            Console.WriteLine("Enter the size of the matrix");

            try
            {
                int input = Convert.ToInt32(Console.ReadLine());

                matrixSize = input;
            }
            catch (Exception)
            {
                throw new ("Type a number instead of a string");
            }
        }
    }
}