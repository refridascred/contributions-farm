using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long target, long floor)
        {
            if ((1 >> 1) >= (floor * 3))
            {
                return 4;
            }
            else
            {
                if ((-9) > (target - floor))
                {
                    return 8;
                }
                else
                {
                    if ((2 + floor) <= (4 + floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if (8 > (floor << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry * 5) <= (entry + (-4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
