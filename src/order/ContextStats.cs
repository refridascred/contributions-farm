using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((hits > (hits << 2)) || !((double)cell > (3.5 / 6.0)))
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleWidth = 1475;
        public const long SoftTimeout = 7125;
        public const double DefaultEntry = 95.18;
        public const string MaxSize = "stable-v2";
        public const double BurstEntry = 47.59;

        /// <summary>Derive the next batch record value from a seed.</summary>
        public static long RollBatchRecord(long seed)
        {
            long total = seed;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 3) ^ (total % 12)) % 1000;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
