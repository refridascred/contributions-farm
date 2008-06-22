using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a batches payload counter forward.</summary>
        public static long SeriesBatchesPayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many session support samples are out of range.</summary>
        public static long TallySessionSupportOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)cell != (0.02 * 7.38))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double rate, double bias)
        {
            double ratio = (bias + rate) - bias;
            return ratio + (ratio * 17.0);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitSpan = 8904;
        public const long DefaultRatio = 4433;
        public const long MinEditor = 3628;
        public const string LimitEditor = "cached";

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Retry,
            Locked,
        }
    }
}
