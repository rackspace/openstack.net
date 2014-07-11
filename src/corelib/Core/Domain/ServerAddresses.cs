//namespace net.openstack.Core.Domain
//{
//    public class ServerAddresses
//    {
//        public Address[] Private { get; set; }
//        public Address[] Public { get; set; }
//    }
//}

using System.Linq;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace net.openstack.Core.Domain
{
    /// <summary>
    /// Represents a map of network labels to collections of IP addresses.
    /// </summary>
    /// <remarks>
    /// The keys of this collection are network labels (see <see cref="CloudNetwork.Label"/>),
    /// and the values are collections of IP addresses.
    /// </remarks>
    /// <threadsafety static="true" instance="false"/>
    [DataContract]
    public class ServerAddresses : Dictionary<string, IEnumerable<Address>>
    {
        /// <summary>
        /// Gets the server IP addresses associated with the <c>private</c> network.
        /// </summary>
        [IgnoreDataMember]
        public IEnumerable<Address> Private
        {
            get
            {
                if (!this.Any(x => x.Key == "private"))
                    return null;

                return this.First(x => x.Key == "private").Value;
            }
        }

        /// <summary>
        /// Gets the server IP addresses associated with the <c>public</c> network.
        /// </summary>
        [IgnoreDataMember]
        public IEnumerable<Address> Public
        {
            get
            {
                if (!this.Any(x => x.Key == "public"))
                    return null;

                return this.First(x => x.Key == "public").Value;
            }
        }

        /// <summary>
        /// Gets the server IP addresses associated with the <c>public</c> network.
        /// </summary>
        [IgnoreDataMember]
        public Dictionary<string, IEnumerable<Address>> Other
        {
            get { return this.Where(x => x.Key != "public" && x.Key != "private").ToDictionary(x => x.Key, x => x.Value);}
        }
    }
}