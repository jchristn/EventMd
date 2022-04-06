using System;
using System.Collections.Generic;
using System.Text;

namespace EventMd
{
    /// <summary>
    /// Identity.
    /// </summary>
    public class IdentityContext
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
        /// Group GUID.
        /// </summary>
        public string GroupGUID { get; set; } = null;

        /// <summary>
        /// Group name.
        /// </summary>
        public string GroupName { get; set; } = null;

        /// <summary>
        /// Metadata.
        /// </summary>
        public object Metadata { get; set; } = null;

        /// <summary>
        /// Instantiate the object.
        /// </summary>
        public IdentityContext()
        {

        }

        /// <summary>
        /// Instantiate the object.
        /// </summary>
        /// <param name="guid">GUID.</param>
        /// <param name="name">Name.</param>
        /// <param name="md">Metadata.</param>
        public IdentityContext(string guid, string name, object md = null)
        {
            GUID = guid;
            Name = name;
            Metadata = md;
        }

        /// <summary>
        /// Instantiate the object.
        /// </summary>
        /// <param name="guid">GUID.</param>
        /// <param name="name">Name.</param>
        /// <param name="groupGuid">Group GUID.</param>
        /// <param name="groupName">Group name.</param>
        /// <param name="md">Metadata.</param>
        public IdentityContext(string guid, string name, string groupGuid, string groupName, object md = null)
        {
            GUID = guid;
            Name = name;
            GroupGUID = groupGuid;
            GroupName = groupName;
            Metadata = md;
        }
    }
}
