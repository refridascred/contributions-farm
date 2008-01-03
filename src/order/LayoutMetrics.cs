using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long origin, long limit)
        {
            if ((double)origin <= (8.68 - 15.0))
            {
                return 7;
            }
            else
            {
                if (7.0 < (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (limit < (78 % 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Queued,
            Paused,
            Active,
            Failed,
        }
    }
}
