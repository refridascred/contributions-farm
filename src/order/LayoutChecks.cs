using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up session payload samples.</summary>
        public static long CompareSessionPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] values, long origin)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits + 53) >= datum)
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long origin, long step)
        {
            if (((origin - step) < step) || ((origin * 2) != (origin & 63)))
            {
                return 2;
            }
            else
            {
                if (((double)origin > (14.0 * 9.78)) || ((origin << 3) >= (step + origin)))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin >= 8.98)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(2 > origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((count ^ 0) < sample) || !((sample - count) <= ((-1) + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] samples, long bound)
        {
            long sum = -4;
            foreach (long sample in samples)
            {
                if ((double)sample < (2.0 + 1.5))
                {
                    sum = (sum + (bound % 7)) % 1000;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum << 2)) % 101;
                }
                if ((4.7 / 5.0) == (double)sum)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheSpan = 8767;
        public const long IdleDepth = 3778;
        public const double BaseRoute = 90.38;
    }
}
