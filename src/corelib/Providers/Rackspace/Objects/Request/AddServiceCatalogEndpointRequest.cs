using System;
using System.Runtime.Serialization;
using net.openstack.Core.Domain;

namespace net.openstack.Providers.Rackspace.Objects.Request
{
    /// <summary>
    /// This models the JSON request used for the Add Endpoint request.
    /// </summary>
    /// <seealso href="http://docs.openstack.org/api/openstack-identity-service/2.0/content/POST_addEndpoint__v2.0_tenants__tenantId__OS-KSCATALOG_endpoints_Endpoint_Operations_OS-KSCATALOG.html">Add Service Catalog Endpoint (OpenStack Identity Service API v2.0 Reference)</seealso>
    /// <threadsafety static="true" instance="false"/>
    [DataContract]
    internal class AddServiceCatalogEndpointRequest
    {
        /// <summary>
        /// Gets additional information about the endpoint template to add.
        /// </summary>
        [DataMember(Name = "OS-KSCATALOG:endpointTemplate")]
        public EndpointTemplate EndpointTemplate { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddServiceCatalogEndpointRequest"/> class for the
        /// specified <paramref name="endpointTemplate"/>.
        /// </summary>
        /// <param name="endpointTemplate">The endpoint template.</param>
        /// <exception cref="ArgumentNullException">If <paramref name="endpointTemplate"/> is <see langword="null"/>.</exception>
        public AddServiceCatalogEndpointRequest(EndpointTemplate endpointTemplate)
        {
            if (endpointTemplate == null)
                throw new ArgumentNullException("endpointTemplate");

            EndpointTemplate = endpointTemplate;
        }
    }
}
