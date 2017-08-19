using GV.WebApi.EthConnector;
using GV.WebApi.IpfsConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace GV.WebApi.Console
{
    public class GenesisVisionModule : Nancy.NancyModule
    {
        private IIpfsConnector ipfsConnector;
        private IEthConnector ethConnector;

        public GenesisVisionModule(
            IIpfsConnector ipfsConnector,
            IEthConnector ethConnector
            )
        {
            this.ipfsConnector = ipfsConnector;
            this.ethConnector = ethConnector;

            Get("/", args => "Genesis Vision Api");

            Get("/traderslist", args => GetTradersList(args));
        }

        private string GetTradersList(dynamic arg)
        {
            throw new NotImplementedException();
        }
    }
}
