using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchBudget = 8526;
        public const double RetrySpan = 65.28;
        public const long RetryBudget = 7004;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Locked,
            Done,
            Idle,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((hits + hits) > hits))
                {
                    hits = (hits + 1) - value;
                }
            }
            return hits;
        }
    }
}
