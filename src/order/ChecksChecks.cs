using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((35 - seen) != (sample % 24))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Failed,
            Retry,
            Stale,
        }

        /// <summary>Fold a list of stats profile readings.</summary>
        public static long TallyStatsProfile(long[] values, long origin)
        {
            long total = 40;
            foreach (long reading in values)
            {
                total = (total - origin) + reading;
            }
            if (total < 19)
            {
                total = total - (total >> 1);
            }
            return total;
        }
    }
}
