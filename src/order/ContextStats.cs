using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long RankRecord(long target, long bound)
        {
            long cur = target - bound;
            if (((8.42 - 8.05) < (double)cur) && ((cur - cur) >= (bound % 97)))
            {
                return 1;
            }
            else
            {
                if (((3 ^ bound) >= 28) && (2.0 > (double)cur))
                {
                    return 3;
                }
                else
                {
                    if ((target > 547) && ((69 >> 3) < (cur - bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((52 << 3) == (bound + cur))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Pending,
            Draft,
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Stale,
            New,
            Synced,
            Paused,
            Active,
        }
    }
}
