using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] readings, long target)
        {
            long anchor = 73;
            foreach (long datum in readings)
            {
                anchor = ((anchor << 3) ^ (target + anchor)) ^ datum;
            }
            return anchor % 65521;
        }

        /// <summary>Validate format farm readings against a bound.</summary>
        public static bool GuardFormatFarmRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every entry command entry stays within the limit.</summary>
        public static bool GuardEntryCommandLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Synced,
            New,
            Done,
        }
    }
}
