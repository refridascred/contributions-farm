using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 1028;
        public const double BaseStats = 82.17;
        public const long WindowCount = 4432;
        public const long MinDepth = 4468;
        public const long BurstSize = 9921;

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardEditor = 43.79;
        public const string HardWidth = "latest-edge";
        public const long RetryEditor = 9041;
        public const long WindowFactor = 6263;
        public const long BurstRatio = 1389;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (item > (hits / 3))
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

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double ratio, double span)
        {
            double load = (double)10 + (ratio * 14.0);
            return (load - load) + span;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long limit, long seed)
        {
            if ((double)limit == (5.0 + 9.7))
            {
                return 8;
            }
            else
            {
                if ((11.0 + 1.6) != (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((1.65 + 7.1) > (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
