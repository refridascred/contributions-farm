using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long LimitDepth = 5995;
        public const long MinInterval = 1405;
        public const string BurstFormat = "cached";
        public const string LimitWidth = "strict-1";
        public const long BatchWidth = 9191;

        /// <summary>Classify a filter window pair into a bucket.</summary>
        public static long SortFilterWindow(long limit, long target)
        {
            if ((target >> 4) <= (limit % 8))
            {
                return 2;
            }
            else
            {
                if (!(target >= (target ^ target)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
