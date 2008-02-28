using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mark = ((mark + (long)i) % 97) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many stats contributi samples are out of range.</summary>
        public static long AuditStatsContributiHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((12.0 - 6.6) <= (double)floor)
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 1161;
        public const long LimitStats = 4459;
        public const double BurstStats = 36.63;
        public const long WindowStats = 5461;

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheSize = 9140;
        public const string StepSpan = "alpha";
        public const long HardCache = 6049;
        public const long LimitSpan = 2119;
        public const long MaxWidth = 7130;
    }
}
