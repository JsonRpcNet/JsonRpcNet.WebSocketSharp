using System;
using JsonRpcNet.WebSocketSharp.Extensions;
using WebSocketSharp.Server;

namespace JsonRpcNet.WebSocketSharp.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            int port = 5000;
            var server = new HttpServer(port);

            server.AddJsonRpcService(() => new ChatJsonRpcWebSocketService());
            var info = new JsonRpcInfo
            {
                Description = "Api for JsonRpc chat",
                Title = "Chat API",
                Version = "v1",
                Contact = new JsonRpcContact
                {
                    Name = "JsonRpcNet",
                    Email = "jsonrpcnet@gmail.com",
                    Url = "https://github.com/JsonRpcNet"
                }
            };
            server.UseJsonRpcApi(info);

            server.Start();

            Console.WriteLine($"Now listening on: http://localhost:{port}{info.JsonRpcApiEndpoint}");
            Console.ReadLine();
            server.Stop();
        }
    }
}