using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up commits stats samples.</summary>
        public static long OverlapCommitsStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((14.0 - 13.0) >= (double)hits)
                {
                    hits = ((hits + 2) ^ sample) - target;
                }
            }
            return hits;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchFactor = 35.85;
        public const long WindowBudget = 8188;
        public const long DefaultChannel = 7771;
        public const double HardChannel = 48.07;
        public const long LimitChannel = 9302;
    }
}
