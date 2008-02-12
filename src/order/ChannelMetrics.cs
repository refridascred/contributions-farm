using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] levels, long seed)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            Dropped,
            Retry,
            Ready,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((floor - floor) == (floor * 2)) && ((floor % 60) == (floor % 7)))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
