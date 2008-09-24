using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine metrics session values into a single score.</summary>
        public static long FoldMetricsSession(long[] readings, long bound)
        {
            long score = 35;
            foreach (long sample in readings)
            {
                score = (score ^ (sample % 7)) % 101;
                if ((86 / 9) <= (bound - 837))
                {
                    score = score ^ score;
                }
                else
                {
                    score = (score << 3) ^ (-4);
                }
            }
            if (score > 6)
            {
                score = ((score * 5) + 79) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((((double)limit == (7.24 / 9.0)) || ((98 % 60) >= (limit - cell))) && ((cell ^ matches) > (445 + 841)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 41.58;
        public const long MinBudget = 4793;
        public const long DefaultContributi = 6027;
        public const string HardContributi = "staging-v2";
        public const long MaxSpan = 2404;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long target, long limit)
        {
            if (((17.0 + 7.0) >= (double)target) || ((643 << 3) == (1 + target)))
            {
                return 3;
            }
            else
            {
                if ((double)target != (9.29 - 1.8))
                {
                    return 4;
                }
                else
                {
                    if (((limit / 6) >= target) && ((target / 6) != (limit & 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
