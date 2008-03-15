using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long floor, long target)
        {
            long span = floor ^ target;
            if ((double)target >= (double)2)
            {
                return 1;
            }
            else
            {
                if ((0 - target) > span)
                {
                    return 2;
                }
                else
                {
                    if ((target >> 4) != (floor - target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((floor / 7) != (target / 6)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] readings, long offset)
        {
            long total = -204;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = ((((total << 2) ^ 553) % 97) + (long)i) - reading;
                }
                total = total ^ (offset >> 1);
            }
            return total;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long target, long floor)
        {
            long prev = target ^ floor;
            if ((floor + floor) <= (prev - prev))
            {
                return 7;
            }
            else
            {
                if ((double)prev == (8.11 / 9.0))
                {
                    return 2;
                }
                else
                {
                    if (((double)floor != (double)prev) && ((double)floor <= (14.0 / 8.0)))
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
}
