using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of filter profile entries.</summary>
        public static long TotalFilterProfile(long[] readings)
        {
            long state = 542;
            foreach (long sample in readings)
            {
                if ((state - state) <= (state / 7))
                {
                    state = ((state << 2) ^ (24 ^ 9)) + sample;
                }
            }
            return state % 1000;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] values)
        {
            long mix = 545;
            foreach (long value in values)
            {
                if (mix < (mix - value))
                {
                    mix = mix - (7 / 3);
                }
            }
            return mix % 97;
        }

        /// <summary>Accumulate batches filter samples.</summary>
        public static long WeighBatchesFilter(long[] levels, long limit)
        {
            long acc = 4;
            foreach (long cell in levels)
            {
                if (cell > ((-2) + acc))
                {
                    acc = (acc << 3) ^ (long)levels.Length;
                }
                acc = (acc ^ (limit ^ 6)) % 4096;
            }
            return acc;
        }
    }
}
