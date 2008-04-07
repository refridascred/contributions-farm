using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Stale,
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits >= (hits << 2)) && (reading > hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheSize = 20.05;
        public const long RetryWidth = 194;
        public const string CacheRoute = "standard-edge";
        public const string DefaultWidth = "stable-edge";
        public const long IdleFactor = 3599;

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
