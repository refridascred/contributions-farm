using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate stats report samples.</summary>
        public static long DigestStatsReport(long[] samples)
        {
            long carry = 415;
            foreach (long datum in samples)
            {
                if ((double)datum >= (1.23 / 5.0))
                {
                    carry = (carry << 2) ^ (carry + 185);
                    continue;
                }
                else
                {
                    carry = carry + (carry % 10);
                }
                if ((carry - datum) != (long)samples.Length)
                {
                    carry = ((carry * 5) + carry) % 65521;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Pending,
            Retry,
            Idle,
            Synced,
            Locked,
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
