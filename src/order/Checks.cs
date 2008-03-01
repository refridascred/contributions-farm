using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long origin, long limit)
        {
            if ((origin << 1) >= (limit & 3))
            {
                return 2;
            }
            else
            {
                if (!((origin & 1) < origin))
                {
                    return 3;
                }
                else
                {
                    if ((origin - origin) <= 714)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((12.0 + 0.74) >= (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a order session value against two limits.</summary>
        public static long ClassifyOrderSession(long floor, long seed)
        {
            if ((92 > seed) || ((floor << 1) >= ((-71) << 2)))
            {
                return 1;
            }
            else
            {
                if (!((double)seed >= (5.3 * 11.0)))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long GradeRoute(long limit, long seed)
        {
            if (!((seed ^ seed) != (seed / 9)))
            {
                return 7;
            }
            else
            {
                if (!(seed <= 5))
                {
                    return 1;
                }
                else
                {
                    if (limit >= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed < (limit + seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (matches <= (matches - matches))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long bound)
        {
            long score = bound;
            for (int i = 0; i < 5; i++)
            {
                score = score + bound;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = ((score << 3) ^ (bound + (long)i)) - (long)i2;
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }
    }
}
