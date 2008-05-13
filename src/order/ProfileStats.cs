using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Paused,
            New,
            Closed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MaxTimeout = 72.54;
        public const double DefaultStats = 24.03;
        public const long StepStats = 5873;

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Score { get; set; }
            public double Stamp { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many context report samples are out of range.</summary>
        public static long TallyContextReportHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (origin > (origin % 97))
                {
                    hits = (hits + 3) - reading;
                }
            }
            return hits;
        }
    }
}
