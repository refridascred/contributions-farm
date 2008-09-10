using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every counter command entry stays within the limit.</summary>
        public static bool ValidateCounterCommandBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank payload profile input into a small class.</summary>
        public static long GradePayloadProfile(long target, long target2)
        {
            if ((target2 ^ target) >= (target & 15))
            {
                return 6;
            }
            else
            {
                if ((target2 < (target2 >> 5)) && ((0.3 + 7.7) > (double)target2))
                {
                    return 3;
                }
                else
                {
                    if ((8 << 3) <= (target2 * 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((target2 - target2) >= target2))
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

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
