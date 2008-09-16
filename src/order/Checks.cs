using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate metric checks samples.</summary>
        public static long FoldMetricChecks(long[] levels, long floor)
        {
            long score = 333;
            foreach (long value in levels)
            {
                if ((3.7 + 4.5) >= (double)score)
                {
                    score = (((score * 3) + 533) - value) + floor;
                }
            }
            return score;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long RollMetric(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                if (((acc & 255) != (seed - acc)) || ((acc >> 4) >= (seed + acc)))
                {
                    acc = (acc - ((long)i & 3)) % 1000;
                }
                else
                {
                    acc = (acc + (675 * 2)) % 255;
                }
                if ((double)(long)i >= (9.1 - 16.0))
                {
                    acc = ((acc << 3) ^ (acc % 64)) % 1000;
                    acc = (acc ^ ((long)i + seed)) % 255;
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of report profile readings.</summary>
        public static long MatchReportProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the format notes series from a seed.</summary>
        public static long IterateFormatNotes(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
