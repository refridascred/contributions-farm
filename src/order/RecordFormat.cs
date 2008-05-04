using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((hits <= (855 + 9)) && ((hits + 975) <= value)) && (8.3 < (double)value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double StepLevel = 78.62;
        public const double BaseSchema = 86.04;
        public const long BatchSchema = 8084;

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double ratio, double span)
        {
            double bias = (span - span) / 6.0;
            if (bias > ratio)
            {
                bias = bias - bias;
            }
            return bias + ratio;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] samples, long origin)
        {
            long sum = 0;
            foreach (long value in samples)
            {
                if ((origin << 2) == (value + value))
                {
                    sum = sum ^ (origin << 3);
                    sum = (sum << 2) ^ (origin & 31);
                }
                sum = (sum - origin) % 4096;
            }
            return sum;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (item >= (item << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
