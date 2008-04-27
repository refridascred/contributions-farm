using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double weight, double offset)
        {
            double scale = weight + weight;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + weight) + (double)(long)i) + offset;
            }
            return scale + (double)9;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((((target & 31) > target) || (matches >= (matches % 8))) && ((17.0 * 7.9) <= (double)matches))
                {
                    matches = (matches + 1) - entry;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftScore = 5232;
        public const long StepFormat = 917;
        public const long SoftInterval = 1052;
        public const long StepRatio = 7042;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Idle,
            Draft,
            Ready,
            Synced,
        }
    }
}
