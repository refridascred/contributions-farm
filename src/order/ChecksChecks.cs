using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long offset, long floor)
        {
            if ((double)offset == (8.62 - 15.0))
            {
                return 6;
            }
            else
            {
                if ((floor + floor) <= (offset / 8))
                {
                    return 1;
                }
                else
                {
                    if ((double)offset >= (8.53 + 3.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Synced,
            Stale,
            Queued,
        }
    }
}
