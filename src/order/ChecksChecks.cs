using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Stale,
            Draft,
            Locked,
            Idle,
            New,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long seed, long bound)
        {
            long next = seed + bound;
            if ((seed - 14) < ((-69) - next))
            {
                return 7;
            }
            else
            {
                if (next <= (next + 218))
                {
                    return 5;
                }
                else
                {
                    if ((12.0 + 9.67) > (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((439 + matches) >= item)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
