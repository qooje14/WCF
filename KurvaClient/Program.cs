using System;
using StudentAverageReference;

namespace KurvaClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StdntAvgClient client = new StdntAvgClient();
            getNameRequest request = new getNameRequest();

            request.name = "Mabdinas Ass";

            getNameResponse response = client.getName(request);

            Console.WriteLine(response.getNameResult);

        }
    }
}
