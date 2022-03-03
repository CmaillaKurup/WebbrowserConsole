using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebbrowserConsole
{
    class Program
    {
        private static readonly HttpClient HttpClient;

        static async Task Main(string[] args)
        {
            var checkConnection = new HttpClientControler();

            Console.Write(checkConnection.HttpClientTest());

            HttpClientControler h = new HttpClientControler();

            await h.HttpClientTest();
        }
    }
}