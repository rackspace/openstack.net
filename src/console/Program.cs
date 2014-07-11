using net.openstack.Providers.Rackspace;
using Net.OpenStack.Testing.Integration;

namespace net.openstack.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Bootstrapper.Initialize();

            var identityProvider = new IdentityProvider(usInstanceUrlBase: "https://identity-internal.api.rackspacecloud.com", 
                ukInstanceUrlBase: "https://lon.identity-internal.api.rackspacecloud.com");

        }
    }
}
