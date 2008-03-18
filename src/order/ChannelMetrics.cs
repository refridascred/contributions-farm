using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count queue farm pairs that satisfy a relation.</summary>
        public static long CompareQueueFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleCount = 504;
        public const long WindowContributi = 7238;
        public const long MinBudget = 9249;
        public const long SoftContributi = 2754;
        public const long BatchLevel = 3431;
    }
}
