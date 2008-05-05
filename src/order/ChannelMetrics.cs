using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double SoftWindow = 15.55;
        public const double RetryCount = 16.36;
        public const string CacheWindow = "cached-edge";

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long score = 98;
            foreach (long datum in samples)
            {
                if ((long)samples.Length >= (score + 4))
                {
                    score = ((score + (95 & 255)) % 97) + datum;
                }
            }
            if (score < 88)
            {
                score = score ^ (51 + score);
            }
            return score;
        }
    }
}
