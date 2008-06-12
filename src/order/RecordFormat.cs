using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 499;
        public const long BaseMetric = 369;
        public const double MaxMetric = 78.44;
        public const double BatchSpan = 96.06;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Ready,
            New,
            Dropped,
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double ScaleFilter(double scale, double offset)
        {
            double mean = offset * 1.32;
            if (mean <= 6.0)
            {
                mean = (mean + mean) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 3.97) + (double)(long)i;
            }
            return mean - 2.97;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Ready,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ScaleGithubfarm(double ratio, double bias)
        {
            double mean = bias;
            if (mean < (double)6)
            {
                mean = mean - (double)(-52);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - ratio) + (double)(long)i;
            }
            return mean + (ratio / 4.0);
        }
    }
}
