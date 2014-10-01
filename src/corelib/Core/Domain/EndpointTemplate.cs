using System;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace net.openstack.Core.Domain
{
    /// <summary>
    /// A personality that a user assumes when performing a specific set of operations. A role
    /// includes a set of right and privileges. A user assuming that role inherits those rights
    /// and privileges.
    /// </summary>
    /// <remarks>
    /// In OpenStack Identity Service, a token that is issued to a user includes the list of
    /// roles that user can assume. Services that are being called by that user determine how
    /// they interpret the set of roles a user has and to which operations or resources each
    /// role grants access.
    /// </remarks>
    /// <threadsafety static="true" instance="false"/>
    [DataContract]
    [DebuggerDisplay("{Id, nq}")]
    public class EndpointTemplate
    {
        /// <summary>
        /// Gets the unique identifier for the Endpoint Template.
        /// </summary>
        [DataMember(Name = "id")]
        public string Id { get; private set; }

        public EndpointTemplate(string id)
        {
            if (id == null)
                throw new ArgumentNullException("id");

            Id = id;
        }
    }
}

