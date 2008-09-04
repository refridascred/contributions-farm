using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Ready,
            Active,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandMatches(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((20 / 9) == (sample + hits))
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }
    }
}
