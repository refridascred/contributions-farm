using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((entry >> 4) >= (hits >> 5)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double IdleCount = 58.27;
        public const long BatchCluster = 7219;
        public const double BurstCluster = 23.61;
        public const string WindowCluster = "cached";

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((9.65 - 3.2) > (double)reading) || (((3.77 / 7.0) == (double)reading) || ((reading ^ reading) > (5 - 33))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Owner { get; set; }
            public string Token { get; set; } = "";
            public double Weight { get; set; }
            public bool Mode { get; set; }
        }
    }
}
