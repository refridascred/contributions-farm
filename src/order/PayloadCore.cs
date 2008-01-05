using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first batches order entry that matches the target.</summary>
        public static long LookupBatchesOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public string Token { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
