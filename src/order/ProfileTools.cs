using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] series, long target)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 9500;
        public const long CacheInterval = 9234;
        public const double RetryLevel = 77.55;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Closed,
            Done,
            Retry,
            Idle,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] data, long offset)
        {
            long anchor = 320;
            foreach (long cell in data)
            {
                if ((cell / 4) == (38 - offset))
                {
                    anchor = (anchor + (6 << 3)) % 255;
                }
                else
                {
                    anchor = (anchor - offset) % 4096;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                long span = 49;
                if ((462 < (mix % 97)) && ((31 - span) < mix))
                {
                    continue;
                }
                else
                {
                    span = (span ^ mix) % 97;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
