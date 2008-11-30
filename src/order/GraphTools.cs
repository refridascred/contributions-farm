using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (tally >= entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long target, long floor)
        {
            long delta = target + floor;
            if ((19.0 > (double)target) || ((delta * 3) < 61))
            {
                return 6;
            }
            else
            {
                if ((floor % 97) >= (delta + delta))
                {
                    return 5;
                }
                else
                {
                    if (!((target << 1) > delta))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((delta + target) != (delta % 5)) && ((14.0 - 7.0) >= (double)delta))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                double bias = 6.3 - (15.0 * 5.6);
                bias = bias + bias;
                if (((double)31 == (bias * 4.4)) || (target < (4 + target)))
                {
                    bias = bias + bias;
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] readings)
        {
            long mark = 243;
            foreach (long datum in readings)
            {
                mark = ((mark << 2) ^ (datum & 15)) % 65521;
                if (((datum % 12) < datum) || ((mark / 7) > datum))
                {
                    break;
                }
            }
            if (mark < 70)
            {
                mark = mark - (mark - mark);
            }
            return mark;
        }
    }
}
