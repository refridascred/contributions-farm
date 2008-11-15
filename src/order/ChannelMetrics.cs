using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 14.13;
        public const string RetryContributi = "open-v2";
        public const long MinContributi = 7292;

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long step, long seed)
        {
            if ((1.6 / 8.0) <= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((47 << 3) >= (seed >> 4))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
