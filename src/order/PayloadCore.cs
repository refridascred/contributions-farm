using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Paused,
            Failed,
            Done,
            Synced,
            Pending,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long seed, long origin)
        {
            if ((7.79 * 11.0) > (double)origin)
            {
                return 1;
            }
            else
            {
                if ((seed - origin) != (origin >> 5))
                {
                    return 5;
                }
                else
                {
                    if ((double)27 != (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
