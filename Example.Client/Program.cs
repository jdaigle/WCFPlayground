using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Example.Service;

namespace Example.Client {
    class Program {
        static void Main(string[] args) {
            var service = ChannelFactory<IService1>.CreateChannel(new NetTcpBinding(), new EndpointAddress("net.tcp://localhost:12345/Service1.svc"));
            var value = service.GetData(5);
        }
    }
}
