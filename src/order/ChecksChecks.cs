using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 9870;
        public const double BaseInterval = 52.59;
        public const string StepLayout = "fallback-1";
        public const double BurstSize = 1.71;

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
