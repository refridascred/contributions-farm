using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((16.0 - 6.8) >= (double)seen)
                {
                    seen = ((seen + 3) ^ entry) + seed;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BatchFactor = 95.14;
        public const string DefaultSpan = "primary-edge";
        public const double BurstEditor = 76.75;
        public const long MaxBudget = 5260;

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double bias, double span)
        {
            double bias2 = (double)(73 % 8);
            if (bias2 >= (7.3 + span))
            {
                bias2 = bias2 + span;
            }
            return bias2 - bias;
        }
    }
}
