using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 984;
        public const long BatchScore = 4523;
        public const double MinLevel = 40.91;
        public const long IdleContributi = 4873;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 3057;
        public const double BatchContributi = 33.44;
        public const long BatchBudget = 8745;
    }
}
