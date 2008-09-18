using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long target, long target2)
        {
            if (((target2 % 24) > (target * 2)) || ((163 / 6) <= target))
            {
                return 8;
            }
            else
            {
                if (target <= (53 - target))
                {
                    return 1;
                }
                else
                {
                    if (target2 < target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (target <= (target * 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((double)item != (13.0 * 3.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Paused,
            Synced,
            Queued,
            Idle,
            Stale,
        }
    }
}
