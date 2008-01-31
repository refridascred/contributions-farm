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

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 2293;
        public const long CacheRoute = 9494;
        public const string BaseRoute = "legacy-v2";
        public const long LimitRoute = 1542;

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

        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long origin)
        {
            long result = origin;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
