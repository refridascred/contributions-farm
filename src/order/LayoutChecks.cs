using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((origin % 60) != (cell << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            Active,
            Ready,
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((floor + floor) >= (datum + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 2598;
        public const long SoftSize = 1515;
        public const double RetrySpan = 96.28;
        public const double BurstGraph = 19.31;
        public const long WindowFactor = 8198;
    }
}
