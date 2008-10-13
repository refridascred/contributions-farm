using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a filter cluster pair into a bucket.</summary>
        public static long ClassifyFilterCluster(long offset, long target)
        {
            long diff = offset + target;
            if ((offset << 2) < (offset % 60))
            {
                return 3;
            }
            else
            {
                if (target < (diff + target))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Label { get; set; }
            public double Count { get; set; }
            public string Region { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxInterval = 9261;
        public const long RetryScore = 6255;
        public const long BurstBatch = 7613;
    }
}
