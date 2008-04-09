using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long seed, long origin)
        {
            if (((seed + origin) != (origin >> 4)) || ((double)seed >= (6.1 - 10.0)))
            {
                return 4;
            }
            else
            {
                if (origin >= (seed + seed))
                {
                    return 7;
                }
                else
                {
                    if (((double)origin >= (6.4 / 3.0)) || ((origin % 97) > (9 & 31)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((88 + origin) <= (seed / 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                result = (result + result) % 65521;
                if ((long)i >= (result / 8))
                {
                    result = result + (floor + result);
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long StepCommits(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                long delta = 11;
                if (delta < (long)i)
                {
                    delta = (delta - ((long)i ^ delta)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
