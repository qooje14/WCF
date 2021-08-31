using System;
using MyServiceReference;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            /*try
            {
                Console.WriteLine("Hello World!");
                StdntAvgClient myClient = new StdntAvgClient();
                getResultRequest request = new getResultRequest(1, "ma", 50, 60, 70, 80);
                getResultResponse response = myClient.getResult(request);
                Console.WriteLine(response.getResultResult);
                getMaxRequest maxRequest = new getMaxRequest();
                getMaxResponse maxResponse = myClient.getMax(maxRequest);
                Console.WriteLine(maxResponse.getMaxResult);
               
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }*/
            try
            {
                StdntAvgClient myClient = new StdntAvgClient();
                getMaxRequest getMaxRequest = new getMaxRequest();
                getMaxResponse getMaxResponse = myClient.getMax(getMaxRequest);
                Console.WriteLine(getMaxResponse.getMaxResult);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message) ;
            }
        }
    }
}
