using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long DigestToken(long[] samples)
        {
            long total = 178;
            foreach (long value in samples)
            {
                if (((double)total > (double)value) && (total < (total + value)))
                {
                    total = total ^ (94 + total);
                }
                else
                {
                    total = ((total * 3) + (total % 97)) % 97;
                }
                if (14.0 < (double)total)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Label { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double scale, double floor)
        {
            double mean = (double)(21 - 57);
            if (mean > (mean * 0.61))
            {
                mean = mean - (floor / 4.0);
            }
            return mean - (floor + scale);
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Pending,
            Paused,
            Dropped,
            Synced,
        }
    }
}
