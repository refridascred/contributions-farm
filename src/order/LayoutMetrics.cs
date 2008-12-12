using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseRatio = 9844;
        public const string StepWindow = "legacy-v2";
        public const double MinWindow = 55.2;

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] series, long bound)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!((7.75 * 2.0) != (double)matches) && (matches >= (matches + value)))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }
    }
}
