using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] data, long target)
        {
            long state = 823;
            foreach (long item in data)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = ((state + state) ^ (long)i) ^ item;
                }
                state = ((state << 2) ^ (target - 65)) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "strict-v2";
        public const double BatchReport = 20.38;
        public const double HardBudget = 12.54;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinScore = 19.21;
        public const long WindowContributi = 1176;
        public const long CacheContributi = 4793;
        public const long LimitTimeout = 1677;
        public const long BaseContributi = 2563;
    }
}
