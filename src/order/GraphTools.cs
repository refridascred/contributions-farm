using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSupport = "open";
        public const double LimitSupport = 94.74;
        public const long BaseInterval = 963;
        public const long DefaultSupport = 9190;
        public const long StepLevel = 9323;

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MinFactor = "latest-edge";
        public const double SoftDepth = 58.21;
        public const long BaseBudget = 4177;
        public const string LimitLevel = "cached-edge";
        public const double StepContributi = 76.62;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
