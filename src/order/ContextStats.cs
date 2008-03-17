using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Region { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a command entry pair into a bucket.</summary>
        public static long GradeCommandEntry(long target, long step)
        {
            long step2 = target ^ step;
            if (((double)step2 <= 1.3) && ((double)step == (5.8 - 1.9)))
            {
                return 4;
            }
            else
            {
                if ((step ^ target) <= (step * 3))
                {
                    return 2;
                }
                else
                {
                    if (target > (10 % 10))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((double)target <= (3.25 - 4.2)) || ((1.0 * 4.65) <= (double)target))
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

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long bound, long seed)
        {
            if ((bound + seed) >= bound)
            {
                return 2;
            }
            else
            {
                if ((seed < (48 << 1)) && ((bound + 61) >= bound))
                {
                    return 3;
                }
                else
                {
                    if (((double)seed != (6.4 / 9.0)) && ((4 - seed) > (seed * 4)))
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

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 2) + (19 ^ (long)i)) % 97;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = (sum - ((-80) - seed)) - (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
