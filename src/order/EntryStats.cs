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

        /// <summary>Count the schema checks entries that pass the check.</summary>
        public static long TallySchemaChecksOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((0 + 4) == (seen - origin))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Pending,
            Synced,
            Active,
            Locked,
            Failed,
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
