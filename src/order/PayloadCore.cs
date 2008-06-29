using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Dropped,
            Closed,
            Idle,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] levels)
        {
            long mix = 813;
            foreach (long entry in levels)
            {
                if ((mix > (4 + mix)) && ((5.0 * 5.47) <= (double)mix))
                {
                    mix = mix - entry;
                }
                if ((mix + mix) < entry)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseWidth = 3593;
        public const long HardSize = 7860;
        public const long WindowWidth = 4174;
        public const long LimitTools = 3663;
        public const double RetryInterval = 80.66;
    }
}
