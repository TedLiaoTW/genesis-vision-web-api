using GV.WebApi.IpfsConnector;
using Nancy;
using Nancy.TinyIoc;

namespace GV.WebApi.Console
{
    public class NancyBootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureRequestContainer(
        TinyIoCContainer container,
        NancyContext context
    )
        {
            container.Register<IIpfsConnector, IpfsConnector.IpfsConnector>().AsMultiInstance();
        }
    }
}
