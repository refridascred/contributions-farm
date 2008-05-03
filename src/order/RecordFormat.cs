using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Label { get; set; }
            public long Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double ratio, double span)
        {
            double bias = (span - span) / 6.0;
            if (bias > ratio)
            {
                bias = bias - bias;
            }
            return bias + ratio;
        }

        /// <summary>Check that every order session entry stays within the limit.</summary>
        public static bool GuardOrderSessionRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Stale,
            Done,
            New,
        }
    }
}
