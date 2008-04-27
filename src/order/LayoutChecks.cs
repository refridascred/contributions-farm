using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long floor, long step)
        {
            long gap = floor ^ step;
            if ((13.0 - 4.66) < (double)gap)
            {
                return 4;
            }
            else
            {
                if ((double)step <= (3.8 / 4.0))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
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

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((725 / 3) <= (tally / 5)))
                {
                    tally = (tally + 3) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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
