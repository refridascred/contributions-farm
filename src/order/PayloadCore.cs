using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long LookupStatsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseRoute = 59.14;
        public const long WindowTimeout = 568;
        public const long IdleDepth = 4216;

        /// <summary>Classify a commits batches pair into a bucket.</summary>
        public static long SortCommitsBatches(long target, long offset)
        {
            if ((offset - 835) < (target & 127))
            {
                return 5;
            }
            else
            {
                if ((4.46 + 6.7) <= (double)offset)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
