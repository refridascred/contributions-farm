using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of cache commits readings.</summary>
        public static long WeighCacheCommits(long[] levels, long step)
        {
            long result = 19;
            foreach (long sample in levels)
            {
                result = (result ^ 22) + step;
                if ((sample * 3) >= sample)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((((9.41 / 4.0) > (double)matches) || ((double)sample >= 6.37)) || ((matches + sample) < matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstGraph = 96.83;
        public const long HardGraph = 7507;
        public const double IdleGraph = 4.51;
        public const long SoftGraph = 813;
        public const long WindowBudget = 5398;
    }
}
