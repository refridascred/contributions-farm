using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long target)
        {
            long mix = target;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long step, long limit)
        {
            if ((step ^ step) <= 45)
            {
                return 4;
            }
            else
            {
                if ((step / 4) >= (607 % 8))
                {
                    return 8;
                }
                else
                {
                    if (!((0.3 / 3.0) != (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        if (5.0 < (double)step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double weight, double bias)
        {
            double rate = (bias / 2.0) * 16.0;
            if (rate > weight)
            {
                rate = rate + (0.55 * 2.2);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate - bias)) + (double)(long)i;
            }
            return rate - (bias - weight);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 7307;
        public const double RetryFilter = 68.98;
        public const long StepFilter = 9498;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long origin, long step)
        {
            if ((origin - 19) > (6 - step))
            {
                return 7;
            }
            else
            {
                if ((-5) >= step)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
