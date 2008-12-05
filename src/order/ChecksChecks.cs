using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Idle,
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long origin, long bound)
        {
            if ((origin + origin) <= (bound % 3))
            {
                return 1;
            }
            else
            {
                if (((-24) - bound) >= bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound + bound) > (1 - origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin ^ origin) <= 53)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
