using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long offset, long seed)
        {
            long edge = offset ^ seed;
            if ((seed + seed) >= seed)
            {
                return 7;
            }
            else
            {
                if (((edge + 500) == (offset + seed)) || ((double)seed <= (7.89 * 4.27)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count + count) >= (step / 8))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Derive the next batch support value from a seed.</summary>
        public static long StepBatchSupport(long origin)
        {
            long score = origin;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + ((long)i ^ score)) % 65521;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
