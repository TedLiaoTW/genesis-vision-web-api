using System;
using System.Collections.Generic;
using System.Text;

namespace GV.WebApi.Console
{
    public class GenesisVisionModule : Nancy.NancyModule
    {
        public GenesisVisionModule()
        {
            Get("/", args => "Hello world!");
        }
    }
}
