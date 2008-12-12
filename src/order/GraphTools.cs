using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of entry session readings.</summary>
        public static long OverlapEntrySessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string DefaultWidth = "strict-edge";
        public const long LimitLayout = 8236;
        public const double CacheBudget = 68.61;
        public const double WindowLayout = 66.66;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value + target) > seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double SmoothChecks(double scale, double bias)
        {
            double weight = 9.5;
            if (weight > (double)52)
            {
                weight = (weight - (scale - 3.2)) + bias;
            }
            return weight + weight;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] readings, long bound)
        {
            long total = 36;
            foreach (long datum in readings)
            {
                if ((52 * 5) == (bound - total))
                {
                    total = total + (total % 8);
                }
                if (datum >= (bound + total))
                {
                    total = (total * 4) + (0 * 2);
                }
            }
            return total;
        }
    }
}
