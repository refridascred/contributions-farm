using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)hits <= 2.0)
                {
                    hits = ((hits + 3) + value) + limit;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] readings, long step)
        {
            long result = 695;
            foreach (long cell in readings)
            {
                if (!((4.0 * 6.3) != (double)step))
                {
                    result = ((result * 5) + (323 * 5)) + cell;
                }
            }
            return result % 97;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long bound, long step)
        {
            long lane = bound - step;
            if ((707 << 2) > lane)
            {
                return 5;
            }
            else
            {
                if ((double)lane <= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (!((368 - step) == (bound - 58)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((50 - lane) < 754) || ((double)lane == (10.0 + 2.2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
