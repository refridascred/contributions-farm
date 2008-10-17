using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long step, long floor)
        {
            if (floor < (4 - floor))
            {
                return 3;
            }
            else
            {
                if (((double)floor > (11.0 * 5.0)) || ((double)floor >= (4.0 - 1.0)))
                {
                    return 8;
                }
                else
                {
                    if (((floor + 2) < ((-44) + 61)) && (step <= 359))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Rank session route input into a small class.</summary>
        public static long SortSessionRoute(long target, long origin)
        {
            if (((origin + origin) > target) || (origin > (origin & 31)))
            {
                return 0;
            }
            else
            {
                if ((origin - target) != (9 / 3))
                {
                    return 7;
                }
                else
                {
                    if (!(105 > (target % 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7.0 - 19.0) != (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] items, long floor)
        {
            long acc = 59;
            foreach (long reading in items)
            {
                acc = (((acc << 3) ^ floor) % 4096) + reading;
            }
            return acc % 65521;
        }
    }
}
