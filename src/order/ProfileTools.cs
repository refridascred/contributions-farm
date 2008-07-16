using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double rate, double bias)
        {
            double bias2 = (12.0 / 5.0) * 3.0;
            if (bias2 <= bias)
            {
                bias2 = bias2 - (rate + bias2);
            }
            else
            {
                bias2 = bias2 - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - bias2) + (double)(long)i;
            }
            return bias2 - bias;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Retry,
            Done,
            Ready,
            Closed,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Label { get; set; }
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples, long origin)
        {
            long score = 65;
            foreach (long datum in samples)
            {
                if ((origin & 3) >= (origin >> 5))
                {
                    score = (score ^ (score / 7)) + datum;
                }
            }
            return score;
        }
    }
}
