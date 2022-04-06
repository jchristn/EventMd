using System;
using System.Collections.Generic;
using System.Text;

namespace EventMd
{
    /// <summary>
    /// Resource.
    /// </summary>
    public class ResourceContext
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
        /// Container.
        /// </summary>
        public string Container { get; set; } = null;

        /// <summary>
        /// Object.
        /// </summary>
        public string Object { get; set; } = null;

        /// <summary>
        /// URI.
        /// </summary>
        public string Uri { get; set; } = null;

        /// <summary>
        /// Metadata.
        /// </summary>
        public object Metadata { get; set; } = null;

        /// <summary>
        /// Instantiate the object.
        /// </summary>
        public ResourceContext()
        {

        }

        /// <summary>
        /// Instantiate the object.
        /// </summary>
        /// <param name="guid">GUID.</param>
        /// <param name="name">Name.</param>
        /// <param name="container">Container.</param>
        /// <param name="obj">Object.</param>
        /// <param name="uri">URI.</param>
        /// <param name="md">Metadata.</param>
        public ResourceContext(string guid, string name, string container, string obj, string uri, object md = null)
        {
            GUID = guid;
            Name = name;
            Container = container;
            Object = obj;
            Uri = uri;
            Metadata = md;
        }
    }
}
