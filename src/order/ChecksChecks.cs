using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Stale,
            Closed,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
