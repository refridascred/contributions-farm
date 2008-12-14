using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the entry batches entries that pass the check.</summary>
        public static long CountEntryBatchesGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((origin >> 2) < (datum & 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)matches > (7.3 + 5.65))
                {
                    matches = ((matches + 3) ^ item) + target;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a stream route sample.</summary>
        public static long LocateStreamRouteIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
