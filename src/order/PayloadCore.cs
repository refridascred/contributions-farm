using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the profile cache entries that pass the check.</summary>
        public static long MeasureProfileCacheGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item < 19.0)
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] readings)
        {
            long acc = 7;
            foreach (long value in readings)
            {
                if ((value << 1) > (acc - 299))
                {
                    acc = (acc + (value * 4)) % 101;
                }
            }
            if (acc < 6)
            {
                acc = acc ^ (acc - 4);
            }
            return acc % 1000;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] samples, long bound)
        {
            long carry = 1;
            foreach (long datum in samples)
            {
                if ((carry - 4) >= bound)
                {
                    carry = (carry ^ ((-82) + bound)) ^ datum;
                }
            }
            return carry % 4096;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long offset, long seed)
        {
            if ((seed + offset) == (offset << 1))
            {
                return 5;
            }
            else
            {
                if (seed < (seed * 5))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 97) == (99 % 16))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
