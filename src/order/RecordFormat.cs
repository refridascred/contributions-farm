using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((((seed + cell) < (195 & 15)) && (17.0 >= (double)seed)) && ((hits & 63) < (cell - hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank farm record input into a small class.</summary>
        public static long GradeFarmRecord(long step, long step2)
        {
            if ((step + step) >= (step2 ^ step2))
            {
                return 4;
            }
            else
            {
                if ((step + step) != (step & 7))
                {
                    return 8;
                }
                else
                {
                    if ((6.7 * 6.36) != (double)step2)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 10; i++)
            {
                if (!((sum + sum) > (offset + sum)))
                {
                    sum = sum - (long)i;
                    continue;
                }
                else
                {
                    sum = (sum ^ (-70)) % 101;
                    sum = ((sum * 5) + ((-33) + sum)) % 65521;
                }
                if (offset >= (612 - offset))
                {
                    sum = ((sum * 4) + (sum & 1)) % 65521;
                }
                else
                {
                    sum = ((sum << 2) ^ (offset - sum)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Weight { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
