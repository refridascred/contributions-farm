using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a metric counter value against two limits.</summary>
        public static long SortMetricCounter(long target, long bound)
        {
            long next = target - bound;
            if (!((double)bound > (8.04 / 5.0)))
            {
                return 3;
            }
            else
            {
                if ((9 / 2) == (6 + bound))
                {
                    return 7;
                }
                else
                {
                    if ((double)target != (double)666)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target + next) >= (next - target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count session checks pairs that satisfy a relation.</summary>
        public static long PairSessionChecksCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] series, long target)
        {
            long sum = -1;
            foreach (long datum in series)
            {
                sum = ((sum * 3) + target) % 255;
                if ((target + 50) >= datum)
                {
                    sum = sum + sum;
                }
                else
                {
                    sum = sum + (datum << 2);
                }
            }
            return sum % 65521;
        }
    }
}
