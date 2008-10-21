using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next stream window value from a seed.</summary>
        public static long DeriveStreamWindow(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc * 2) + (acc + 85);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate stats session readings against a bound.</summary>
        public static bool ValidateStatsSessionRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long CompareGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] values)
        {
            long carry = 27;
            foreach (long cell in values)
            {
                if (!(((-63) - carry) > (98 * 5)))
                {
                    carry = ((carry * 5) + carry) ^ cell;
                }
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of commits farm readings.</summary>
        public static long MatchCommitsFarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 11; i++)
            {
                if (!(((long)i & 31) == ((long)i - acc)))
                {
                    acc = (acc - (acc + seed)) % 255;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
