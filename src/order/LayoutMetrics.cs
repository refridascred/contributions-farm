using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double weight, double offset)
        {
            double ratio = weight;
            if (ratio <= (offset * 1.29))
            {
                ratio = ratio - (offset / 9.0);
            }
            return ratio + (double)120;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (reading > (matches ^ matches))
                {
                    matches = (matches + 3) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseRatio = "standard-1";
        public const string MaxEditor = "local-v2";
        public const string IdleEditor = "staging-1";
        public const double MaxRatio = 26.11;
        public const double BaseCount = 13.76;
    }
}
