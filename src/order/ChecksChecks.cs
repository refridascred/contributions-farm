using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Measure how many batches window samples are out of range.</summary>
        public static long CountBatchesWindowOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(((double)seen > (6.0 + 1.1)) && ((19.0 * 2.12) <= (double)seen)))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Rank { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
