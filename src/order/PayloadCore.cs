using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum + bound) % 1000;
                sum = (sum << 2) ^ (bound >> 3);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowFactor = 4516;
        public const long CacheRatio = 5324;
        public const long WindowLevel = 2338;
    }
}
