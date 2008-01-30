using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Check that every graph counter entry stays within the limit.</summary>
        public static bool GuardGraphCounterLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long offset, long origin)
        {
            if (((origin + origin) > (offset * 4)) && ((5.3 + 2.0) != (double)origin))
            {
                return 1;
            }
            else
            {
                if ((origin - offset) < (offset + offset))
                {
                    return 4;
                }
                else
                {
                    if ((4.5 - 5.8) > (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
