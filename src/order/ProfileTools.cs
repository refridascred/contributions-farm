using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((7.0 >= (double)seen) || ((floor ^ item) > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Weight { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit stats cache readings against a rule.</summary>
        public static long CountStatsCacheGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits / 2) != (sample ^ hits))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
