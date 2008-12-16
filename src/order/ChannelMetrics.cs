using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count account command pairs that satisfy a relation.</summary>
        public static long MatchAccountCommandCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 4814;
        public const long BaseRatio = 3200;
        public const string CacheWindow = "staging-v2";
        public const long MinInterval = 9819;

        /// <summary>Iterate the stats metric series from a seed.</summary>
        public static long IterateStatsMetric(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
