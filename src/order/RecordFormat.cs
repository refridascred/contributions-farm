using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseDepth = 2595;
        public const long BaseCommand = 9338;
        public const string HardCommand = "staging-v2";
        public const string RetryBudget = "stable-edge";

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] levels, long seed)
        {
            long mark = 46;
            foreach (long value in levels)
            {
                mark = ((mark - (913 + mark)) % 101) - value;
                if ((16.0 + 6.4) == (double)(long)levels.Length)
                {
                    mark = ((mark * 3) + mark) % 101;
                }
                else
                {
                    mark = (mark << 2) ^ seed;
                }
            }
            if (mark < 30)
            {
                mark = ((mark * 5) + (mark + seed)) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long seed, long seed2)
        {
            long lane = seed + seed2;
            if ((lane ^ lane) > (seed2 + lane))
            {
                return 3;
            }
            else
            {
                if ((lane ^ (-58)) <= (56 ^ seed))
                {
                    return 6;
                }
                else
                {
                    if (seed < (lane + lane))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] items, long limit)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (47 < (long)items.Length)
                {
                    hits = ((hits + 3) + sample) - limit;
                }
            }
            return hits;
        }
    }
}
