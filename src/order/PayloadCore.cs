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

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Score { get; set; }
            public double Offset { get; set; }
            public long Limit { get; set; }
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
