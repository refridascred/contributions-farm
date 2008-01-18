using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the queue stream entries that pass the check.</summary>
        public static long CountQueueStreamHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally ^ entry) > floor)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of support tools readings.</summary>
        public static long MatchSupportToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] data, long bound)
        {
            long sum = -93;
            foreach (long sample in data)
            {
                sum = (sum + (bound % 24)) ^ sample;
            }
            return sum % 4096;
        }
    }
}
