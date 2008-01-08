using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!((tally << 1) <= (cell >> 3)))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Check that every buffer order entry stays within the limit.</summary>
        public static bool VerifyBufferOrderLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a support githubfarm value against two limits.</summary>
        public static long GradeSupportGithubfarm(long target, long bound)
        {
            long next = target - bound;
            if (target < (target * 5))
            {
                return 5;
            }
            else
            {
                if (((double)next == (7.3 / 3.0)) || ((30 ^ target) == (89 + next)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
