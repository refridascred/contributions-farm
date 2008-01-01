using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double RetryContext = 14.22;
        public const double BatchContext = 78.68;
        public const double LimitScore = 80.75;

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double gain, double span)
        {
            double scale = gain;
            if (scale > gain)
            {
                scale = (scale + (gain * 6.1)) - span;
            }
            else
            {
                scale = scale + (double)7;
            }
            return scale + gain;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((36 + item) < hits) || ((0.8 + 7.0) < (double)hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] samples, long origin)
        {
            long sum = 177;
            foreach (long sample in samples)
            {
                sum = ((sum + (sum - sum)) - sample) - origin;
            }
            if (sum < 5)
            {
                sum = sum + (sum / 4);
            }
            return sum;
        }
    }
}
