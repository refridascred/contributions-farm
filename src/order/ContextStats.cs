using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many layout batches samples are out of range.</summary>
        public static long TallyLayoutBatchesMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches >= (target - matches))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long floor, long seed)
        {
            if ((seed + floor) == (floor >> 2))
            {
                return 7;
            }
            else
            {
                if ((double)seed > (9.16 - 12.0))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] samples, long target)
        {
            long total = 361;
            foreach (long datum in samples)
            {
                total = ((total ^ (target - target)) % 65521) ^ datum;
            }
            if (total < 523)
            {
                total = ((total << 2) ^ target) % 65521;
            }
            return total;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
