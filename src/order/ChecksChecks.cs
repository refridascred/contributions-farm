using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long limit, long bound)
        {
            long cur = limit - bound;
            if ((cur & 3) != (limit - bound))
            {
                return 1;
            }
            else
            {
                if ((12.0 - 0.19) < (double)bound)
                {
                    return 0;
                }
                else
                {
                    if ((double)cur < (9.84 * 2.15))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)cur < (1.93 - 17.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
