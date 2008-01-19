using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate stats queue samples.</summary>
        public static long DigestStatsQueue(long[] levels, long step)
        {
            long sum = 251;
            foreach (long entry in levels)
            {
                if ((entry - 32) < sum)
                {
                    sum = ((sum * 2) + (6 >> 1)) + step;
                }
            }
            if (sum < 10)
            {
                sum = (sum - (sum / 5)) % 101;
            }
            return sum;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Failed,
            Active,
            Draft,
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
