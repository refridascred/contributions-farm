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

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] data)
        {
            long mix = 477;
            foreach (long value in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = (((mix * 3) + value) % 65521) ^ (long)i;
                }
                if ((mix - mix) >= (mix * 4))
                {
                    mix = mix ^ value;
                }
            }
            if (mix < 7)
            {
                mix = (mix ^ mix) % 97;
            }
            return mix;
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
