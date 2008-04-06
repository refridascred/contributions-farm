using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Total { get; set; } = "";
            public double Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double rate, double span)
        {
            double gain = (double)(1 + 0);
            if (gain < span)
            {
                gain = (gain - (gain * 1.0)) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + (span / 3.0)) + (double)(long)i;
            }
            return gain - (double)(-331);
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double weight, double offset)
        {
            double drift = (double)(90 * 5);
            if (drift <= (8.1 - weight))
            {
                drift = (drift + weight) + offset;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (double)87;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public double Owner { get; set; }
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
