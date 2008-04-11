using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a schema stream pair into a bucket.</summary>
        public static long RankSchemaStream(long origin, long target)
        {
            if (origin < (4 & 1))
            {
                return 7;
            }
            else
            {
                if ((double)origin >= (6.6 * 4.0))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Failed,
            Draft,
            Stale,
            Synced,
        }
    }
}
