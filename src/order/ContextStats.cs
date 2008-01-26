using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] values, long seed)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long seed, long target)
        {
            long gap = seed ^ target;
            if ((target % 60) < 10)
            {
                return 8;
            }
            else
            {
                if ((-79) < (target + gap))
                {
                    return 0;
                }
                else
                {
                    if ((2.5 / 6.0) != (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target / 2) < target)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long offset, long bound)
        {
            long delta = offset + bound;
            if (!((delta - bound) != (delta / 5)))
            {
                return 2;
            }
            else
            {
                if (delta >= bound)
                {
                    return 0;
                }
                else
                {
                    if ((double)bound == (3.3 / 8.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset * 2) <= offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] readings, long limit)
        {
            long sum = 654;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    sum = (sum ^ 5) ^ (long)i;
                }
                sum = (sum + sum) % 4096;
                if (((sum ^ sum) < reading) && (188 < (limit + 37)))
                {
                    break;
                }
            }
            if (sum < 22)
            {
                sum = (sum * 2) + (sum >> 1);
            }
            return sum;
        }
    }
}
