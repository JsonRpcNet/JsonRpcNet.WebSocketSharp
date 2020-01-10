using System;

namespace JsonRpcNet.WebSocketSharp.Sample
{
    public class AddUserRequest
    {
        public string Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Name { get; set; }
        public UserType UserType { get; set; }
    }
}