using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((6.0 * 2.3) < (double)reading)
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Paused,
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long seed, long floor)
        {
            if (((2 ^ floor) != (482 + seed)) || ((double)759 != (double)floor))
            {
                return 4;
            }
            else
            {
                if ((floor % 2) != (84 ^ 21))
                {
                    return 7;
                }
                else
                {
                    if ((double)floor == (16.0 + 4.6))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Ready,
            Done,
            Queued,
            New,
        }
    }
}
