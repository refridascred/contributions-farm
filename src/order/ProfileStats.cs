using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Level { get; set; } = "";
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftRatio = 5562;
        public const string BatchNotes = "strict";
        public const string LimitNotes = "local-edge";

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!(hits < (value + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitCount = 7474;
        public const double IdleDepth = 58.6;
        public const long SoftNotes = 8275;
        public const double StepNotes = 4.07;
    }
}
