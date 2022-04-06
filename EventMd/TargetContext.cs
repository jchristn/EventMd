using System;
using System.Collections.Generic;
using System.Text;

namespace EventMd
{
    /// <summary>
    /// Target.
    /// </summary>
    public class TargetContext
    {
        /// <summary>
        /// GUID.
        /// </summary>
        public string GUID { get; set; } = null;

        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; set; } = null;

        /// <summary>
        /// IP address.
        /// </summary>
        public string IpAddress { get; set; } = null;

        /// <summary>
        /// Hostname.
        /// </summary>
        public string Hostname { get; set; } = null;

        /// <summary>
        /// Metadata.
        /// </summary>
        public object Metadata { get; set; } = null;

        /// <summary>
        /// Instantiate the object.
        /// </summary>
        public TargetContext()
        {

        }

        /// <summary>
        /// Instantiate the object.
        /// </summary>
        /// <param name="guid">GUID.</param>
        /// <param name="name">Name.</param>
        /// <param name="ipAddress">IP address.</param>
        /// <param name="hostname">Hostname.</param>
        /// <param name="md">Metadata.</param>
        public TargetContext(string guid, string name, string ipAddress, string hostname, object md = null)
        {
            GUID = guid;
            Name = name;
            IpAddress = ipAddress;
            Hostname = hostname;
            Metadata = md;
        }
    }
}
