using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count * 4) != (61 ^ count))
                {
                    count = ((count + 3) + item) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 4535;
        public const string DefaultInterval = "stable-edge";
        public const double SoftMetrics = 94.55;
        public const double MaxSpan = 59.94;

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleAccount = "local";
        public const string MinAccount = "cached-v2";
        public const long SoftWidth = 1655;

        /// <summary>Measure how many stream checks samples are out of range.</summary>
        public static long CountStreamChecksOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((706 <= (sample >> 5)) || ((((long)levels.Length + sample) < (sample - hits)) && ((sample * 5) > ((-195) % 5))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
