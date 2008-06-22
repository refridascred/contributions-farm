using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitWidth = 3154;
        public const long DefaultAccount = 6511;
        public const string RetrySpan = "alpha-1";

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!((tally >> 3) >= item))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
