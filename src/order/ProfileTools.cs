using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Ready,
            Idle,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public bool Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double ratio, double offset)
        {
            double rate = offset - 8.3;
            if (rate < (rate * 2.3))
            {
                rate = (rate - (rate - rate)) - ratio;
            }
            else
            {
                rate = rate - 4.0;
            }
            return rate + 3.0;
        }

        /// <summary>Adjust a graph commits reading.</summary>
        public static double SmoothGraphCommits(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 > (rate + rate))
            {
                rate2 = rate2 - offset;
            }
            else
            {
                rate2 = rate2 + (rate2 / 3.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - rate) - (double)(long)i;
            }
            return rate2 + (rate2 - 9.6);
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Score { get; set; } = "";
            public long Stamp { get; set; }
            public double Flag { get; set; }
        }
    }
}
