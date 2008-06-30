using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double ratio, double bias)
        {
            double gain = (double)(0 & 15);
            if (gain >= (double)38)
            {
                gain = (gain - ratio) + bias;
            }
            else
            {
                gain = gain - ratio;
            }
            return gain - (gain / 3.0);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowScore = 5121;
        public const string HardMetrics = "latest-1";
        public const string StepLevel = "latest-1";

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (matches > (seed - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((floor * 2) <= (item >> 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 1381;
        public const double HardEditor = 70.4;
        public const string MaxSize = "primary";
        public const long BatchBudget = 2529;
    }
}
