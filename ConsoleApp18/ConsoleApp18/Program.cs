using System;
using System.Linq;
using System.Data.SqlClient;

class MyClass
{

    static void Main(string[] args)
    {

        int count = Convert.ToInt32(Console.ReadLine());

        int[] numbers = new int[count];

        string ip = Console.ReadLine();

        string[] givenValues = ip.Split(' ');

        for (int i = 0; i < givenValues.Length; i++)
        {
            numbers[i] = Convert.ToInt32(givenValues[i]);
        }

        int countMin = numbers[0];

        for (int i = 0; i < givenValues.Length; i++)
        {
            if (numbers[i] < countMin)
            {
                countMin = numbers[i];
            }
        }

        Console.WriteLine(countMin);



        SqlConnection conn = new SqlConnection("Data Source=(local);Initial Catalog=Northwind;Integrated Security=SSPI");

        SqlCommand cmd = new SqlCommand( "select * from Customers", conn);

        SqlDataReader rdr = cmd.ExecuteReader();


    }
}
