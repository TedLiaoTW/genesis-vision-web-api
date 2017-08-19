using GV.WebApi.IpfsConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace GV.WebApi.Console
{
    public class GenesisVisionModule : Nancy.NancyModule
    {
        private IIpfsConnector ipfsConnector;

        public GenesisVisionModule(IIpfsConnector ipfsConnector)
        {
            this.ipfsConnector = ipfsConnector;

            Get("/", args => "Genesis Vision Api");

            Get("/traderslist", args => GetTradersList(args));
        }

        private string GetTradersList(dynamic arg)
        {
            throw new NotImplementedException();
        }
    }
}
