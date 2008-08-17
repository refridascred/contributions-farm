using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double ratio, double offset)
        {
            double gain = ratio;
            if (gain > (double)(-59))
            {
                gain = (gain - (gain * 19.0)) - offset;
            }
            return gain + (ratio / 3.0);
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitRatio = 3.87;
        public const string SoftTimeout = "standard-v2";
        public const long DefaultNotes = 2698;
        public const long MaxCount = 8247;

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
