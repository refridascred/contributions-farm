using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Ready,
            Pending,
            Failed,
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Level { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            Active,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Roll a queue metric counter forward.</summary>
        public static long DeriveQueueMetric(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                result = (result << 3) ^ 53;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
