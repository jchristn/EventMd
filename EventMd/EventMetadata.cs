using System;
using OpenAuditLog;

namespace EventMd
{
    /// <summary>
    /// Event metadata.
    /// </summary>
    public class EventMetadata
    {
        /// <summary>
        /// Identity.
        /// </summary>
        public IdentityContext Identity { get; set; } = null;

        /// <summary>
        /// Source.
        /// </summary>
        public SourceContext Source { get; set; } = null;

        /// <summary>
        /// Target.
        /// </summary>
        public TargetContext Target { get; set; } = null;

        /// <summary>
        /// Resource.
        /// </summary>
        public ResourceContext Resource { get; set; } = null;

        /// <summary>
        /// Metadata.
        /// </summary>
        public object Metadata { get; set; } = null;

        /// <summary>
        /// Event type.
        /// </summary>
        public string Type { get; set; } = null;

        /// <summary>
        /// Event result.
        /// </summary>
        public EventResult Result { get; set; } = EventResult.Success;

        /// <summary>
        /// Content length.
        /// </summary>
        public long ContentLength { get; set; } = 0;

        /// <summary>
        /// Timestamp of the event.
        /// </summary>
        public DateTime TimestampUtc { get; set; } = DateTime.Now.ToUniversalTime();

        /// <summary>
        /// Instantiate the object.
        /// </summary>
        public EventMetadata()
        {

        }

        /// <summary>
        /// Instantiate the object.
        /// </summary>
        /// <param name="identity">Identity.</param>
        /// <param name="source">Source.</param>
        /// <param name="target">Target.</param>
        /// <param name="resource">Resource.</param>
        /// <param name="metadata">Metadata.</param>
        /// <param name="eventType">Event type.</param>
        /// <param name="result">Result.</param>
        /// <param name="contentLength">Content length.</param>
        public EventMetadata(
            IdentityContext identity,
            SourceContext source,
            TargetContext target,
            ResourceContext resource,
            object metadata,
            string eventType,
            EventResult result,
            long contentLength)
        {
            Identity = identity;
            Source = source;
            Target = target;
            Resource = resource;
            Metadata = metadata;
            Type = eventType;
            Result = result;
            ContentLength = contentLength;
        }

        /// <summary>
        /// Create an audit log entry from the event metadata.
        /// </summary>
        /// <returns>Audit log entry.</returns>
        public AuditLogEntry ToAuditLogEntry()
        {
            return new AuditLogEntry(
                Identity,
                Source,
                Target,
                Resource,
                Metadata,
                Type,
                Result,
                ContentLength);
        }
    }
}
