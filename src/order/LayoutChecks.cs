using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Owner { get; set; }
            public long Label { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long origin2)
        {
            if (!((origin2 >> 3) >= (origin - 41)))
            {
                return 7;
            }
            else
            {
                if ((origin2 / 5) < (origin2 + origin2))
                {
                    return 6;
                }
                else
                {
                    if ((75 - origin) < (10 * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin2 + origin) != (origin2 & 31))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Paused,
            Closed,
            Queued,
            Retry,
            Failed,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item & 15) <= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }
    }
}
