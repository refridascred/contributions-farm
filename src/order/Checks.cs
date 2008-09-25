using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a layout channel counter forward.</summary>
        public static long SeriesLayoutChannel(long seed)
        {
            long state = seed;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 3) + (469 * 3)) % 97;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long offset, long step)
        {
            long next = offset ^ step;
            if ((next < 983) || (step >= (next % 8)))
            {
                return 1;
            }
            else
            {
                if (((step / 6) < (offset + offset)) && (offset <= next))
                {
                    return 3;
                }
                else
                {
                    if ((next + 5) == (next << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Pending,
            Queued,
            Paused,
        }

        /// <summary>Digest a series of report notes entries.</summary>
        public static long TallyReportNotes(long[] readings)
        {
            long score = 7;
            foreach (long item in readings)
            {
                if (((item % 8) <= (90 ^ (-914))) && (item <= (572 % 5)))
                {
                    score = (score * 2) + (2 & 15);
                }
            }
            return score;
        }
    }
}
