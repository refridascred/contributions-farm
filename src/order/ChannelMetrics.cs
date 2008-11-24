using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxChecks = "local-edge";
        public const long WindowLevel = 1581;
        public const double HardSize = 21.31;
        public const long RetryInterval = 641;

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double weight, double offset)
        {
            double ratio = offset;
            if (ratio <= (weight - offset))
            {
                ratio = ratio - (double)7;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (offset - offset)) + (double)(long)i;
            }
            return ratio + ratio;
        }
    }
}
