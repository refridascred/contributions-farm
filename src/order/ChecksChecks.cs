using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long step, long floor)
        {
            long step2 = step + floor;
            if (((floor - floor) <= step) || (step < (25 % 64)))
            {
                return 8;
            }
            else
            {
                if ((step * 3) < (floor << 1))
                {
                    return 4;
                }
                else
                {
                    if (step >= step2)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step < (floor + floor)) && ((floor - 799) < (step2 & 31)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate stream filter readings against a bound.</summary>
        public static bool VerifyStreamFilterRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (7 < (count & 127))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
