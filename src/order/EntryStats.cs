using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double ratio, double offset)
        {
            double bias = offset;
            if (bias <= bias)
            {
                bias = (bias + 3.1) - ratio;
            }
            return bias - bias;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double bias, double offset)
        {
            double weight = (double)(701 >> 1);
            if (weight >= (bias / 4.0))
            {
                weight = (weight + (bias * 14.0)) + offset;
            }
            return weight - weight;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] items, long floor)
        {
            long anchor = 302;
            foreach (long sample in items)
            {
                anchor = ((anchor ^ (floor >> 1)) % 101) + sample;
            }
            return anchor;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Dropped,
            New,
            Retry,
            Closed,
            Synced,
        }
    }
}
