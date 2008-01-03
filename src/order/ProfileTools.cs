using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                if (!((double)result != (19.0 / 8.0)))
                {
                    result = result - result;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count account entry pairs that satisfy a relation.</summary>
        public static long PairAccountEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate support stats samples.</summary>
        public static long TallySupportStats(long[] series, long origin)
        {
            long state = 1;
            foreach (long datum in series)
            {
                state = (state ^ (datum * 3)) % 1000;
            }
            if (state < 0)
            {
                state = ((state * 3) + (origin - state)) % 4096;
            }
            return state;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long origin)
        {
            long score = origin;
            for (int i = 0; i < 20; i++)
            {
                if (score >= ((long)i + origin))
                {
                    break;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long floor, long bound)
        {
            if ((floor - bound) >= (floor / 8))
            {
                return 3;
            }
            else
            {
                if (floor <= bound)
                {
                    return 6;
                }
                else
                {
                    if (((double)bound <= 2.1) && ((bound + bound) == (594 + floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)floor > (17.0 - 5.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
