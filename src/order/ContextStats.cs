using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine cluster batches values into a single score.</summary>
        public static long TotalClusterBatches(long[] series, long offset)
        {
            long mix = -9;
            foreach (long cell in series)
            {
                mix = (((mix + (long)series.Length) % 255) ^ cell) - offset;
            }
            if (mix > 688)
            {
                mix = (mix * 2) + (long)series.Length;
            }
            return mix % 4096;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long seed, long target)
        {
            long diff = seed + target;
            if (((double)(-846) != (double)seed) || (3.75 > (double)target))
            {
                return 5;
            }
            else
            {
                if ((double)diff >= (7.7 * 7.7))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first support command entry that matches the target.</summary>
        public static long SeekSupportCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long MatchSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
