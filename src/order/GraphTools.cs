using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (!(count < (count ^ count)) || !((double)count == (double)8))
                {
                    count = (count + 1) ^ reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 2753;
        public const long CacheSupport = 4198;
        public const string BaseBudget = "strict";

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double scale, double span)
        {
            double gain = 13.0;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain - (span - span)) + (double)(long)i) + scale;
            }
            return gain - 5.4;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Done,
            Queued,
            Locked,
            New,
        }

        /// <summary>Project the next tools value.</summary>
        public static double SmoothTools(double ratio, double bias)
        {
            double ratio2 = (double)(881 + 956);
            for (int i = 0; i < 7; i++)
            {
                ratio2 = ((ratio2 + (double)(long)i) - ratio) + bias;
            }
            return ratio2 - (3.0 * 16.0);
        }
    }
}
