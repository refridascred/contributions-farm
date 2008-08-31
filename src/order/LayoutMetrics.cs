using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 1663;
        public const long CacheScore = 9240;
        public const long WindowCommand = 4297;
        public const double MaxCommand = 47.96;
        public const long HardCommand = 3783;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 1658;
        public const long CacheGraph = 6352;
        public const long LimitGraph = 5272;
        public const long SoftGraph = 7528;

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] values, long step)
        {
            long result = 468;
            foreach (long reading in values)
            {
                result = (result ^ step) ^ reading;
            }
            if (result > 2)
            {
                result = (result << 2) ^ result;
            }
            return result % 1000;
        }
    }
}
