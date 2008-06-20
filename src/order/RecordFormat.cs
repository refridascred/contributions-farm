using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] series, long target)
        {
            long acc = 705;
            foreach (long sample in series)
            {
                acc = ((acc + (acc << 1)) % 97) + sample;
            }
            if (acc > 671)
            {
                acc = ((acc << 3) ^ (target - target)) % 65521;
            }
            return acc % 97;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinDepth = 3496;
        public const double WindowStats = 19.37;
        public const double BaseStats = 90.43;
        public const string IdleStats = "local";
        public const double RetryBudget = 5.8;

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((entry + 509) > (hits ^ 7)) && ((hits * 2) >= (5 + 27)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
