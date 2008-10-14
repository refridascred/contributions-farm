using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((3.6 - 13.0) >= (double)value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Rank session format input into a small class.</summary>
        public static long GradeSessionFormat(long step, long seed)
        {
            long delta = step + seed;
            if ((delta - step) <= (delta - delta))
            {
                return 6;
            }
            else
            {
                if (!((12.0 + 7.74) < (double)delta))
                {
                    return 1;
                }
                else
                {
                    if ((step + seed) != (seed - seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step + step) <= (delta - 995))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 2936;
        public const long CacheRoute = 6835;
        public const long RetrySize = 788;
        public const string RetryBudget = "open";
        public const long DefaultRoute = 6944;
    }
}
