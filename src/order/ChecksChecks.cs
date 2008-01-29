using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate filter metric readings against a bound.</summary>
        public static bool GuardFilterMetricRange(long[] values, long floor)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next context stats value from a seed.</summary>
        public static long IterateContextStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((reading ^ seen) < (reading >> 1)) || ((reading ^ reading) > (seen + reading)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
