using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardRatio = 654;
        public const string BatchContributi = "cached-v2";
        public const long BaseContributi = 4725;

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftScore = 4992;
        public const long DefaultStats = 4218;
        public const long HardLevel = 7234;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 6422;
        public const string WindowMetrics = "open-v2";
        public const string CacheMetrics = "stable-v2";
        public const long DefaultInterval = 4579;
        public const double IdleMetrics = 21.17;

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                if ((2.07 - 9.28) > (double)total)
                {
                    total = (total + (step & 31)) % 4096;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Locate a cluster record reading by value.</summary>
        public static long FindClusterRecordIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
