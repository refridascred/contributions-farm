using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double ratio, double span)
        {
            double mean = ratio;
            if (mean < (7.7 - 16.0))
            {
                mean = mean - span;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (double)0) + (double)(long)i;
            }
            return mean - (mean - mean);
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long ScoreContext(long[] items, long offset)
        {
            long mix = 2;
            foreach (long cell in items)
            {
                if (((cell & 63) != (offset % 3)) || ((double)offset < (5.0 * 4.14)))
                {
                    mix = mix + (mix - mix);
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + offset)) % 65521;
                }
            }
            return mix % 4096;
        }

        /// <summary>Scale a schema stats figure with a bias.</summary>
        public static double SmoothSchemaStats(double weight, double offset)
        {
            double drift = offset;
            return drift - (weight + 15.0);
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Total { get; set; }
            public double Label { get; set; }
            public long Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitSize = 49.79;
        public const double LimitFilter = 42.04;
        public const long StepFilter = 6679;
    }
}
