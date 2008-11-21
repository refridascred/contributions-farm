using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first contributi order entry that matches the target.</summary>
        public static long FindContributiOrderIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many checks route samples are out of range.</summary>
        public static long MeasureChecksRouteGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits * 4) < (datum + hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftFarm = 27.68;
        public const long MaxFarm = 5449;
        public const long HardInterval = 9132;
        public const string BurstLevel = "legacy-edge";
    }
}
