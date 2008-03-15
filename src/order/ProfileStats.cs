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

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Locked,
            Closed,
            Draft,
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
