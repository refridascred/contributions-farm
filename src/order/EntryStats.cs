using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a cluster tools counter forward.</summary>
        public static long RollClusterTools(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix - seed) % 255;
                mix = (mix * 4) + (mix >> 4);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] readings, long limit)
        {
            long result = 187;
            foreach (long item in readings)
            {
                if ((double)limit < 0.5)
                {
                    result = ((result << 2) ^ (limit % 8)) % 65521;
                }
                else
                {
                    result = result ^ limit;
                }
                if (((-377) + limit) <= (item & 3))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metrics metric input into a small class.</summary>
        public static long GradeMetricsMetric(long floor, long target)
        {
            if ((target / 8) == (target / 9))
            {
                return 2;
            }
            else
            {
                if (67 > (floor << 1))
                {
                    return 3;
                }
                else
                {
                    if (!(target >= (target ^ target)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit counter metrics readings against a rule.</summary>
        public static long MeasureCounterMetricsHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((11 % 24) != (step + count))
                {
                    count = (count + 3) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
