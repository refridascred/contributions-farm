using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
