using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double rate, double offset)
        {
            double scale = 0.68;
            if (scale <= scale)
            {
                scale = (scale + rate) - offset;
            }
            return scale + 3.0;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 8386;
        public const string HardSpan = "primary";
        public const double HardCount = 66.01;

        /// <summary>Compare every pair of farm readings.</summary>
        public static long MatchFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
