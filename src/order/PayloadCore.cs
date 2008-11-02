using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepSize = 3901;
        public const double BaseInterval = 47.13;
        public const long DefaultWidth = 8892;
        public const long LimitBuffer = 1629;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long offset, long offset2)
        {
            long slot = offset ^ offset2;
            if (((886 - slot) >= 3) && ((slot - offset2) == (offset + offset)))
            {
                return 0;
            }
            else
            {
                if (((offset2 + offset2) == (slot + offset2)) && (offset <= (offset * 2)))
                {
                    return 5;
                }
                else
                {
                    if ((offset2 << 2) > (offset ^ 37))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((2.8 - 0.8) >= (double)seen)
                {
                    seen = (seen + 2) ^ item;
                }
            }
            return seen;
        }
    }
}
