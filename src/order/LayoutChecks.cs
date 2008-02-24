using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Dropped,
            Pending,
            New,
        }

        /// <summary>Validate already editor readings against a bound.</summary>
        public static bool CheckAlreadyEditorLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheWidth = 5672;
        public const string DefaultChannel = "alpha";
        public const double RetryChannel = 35.68;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)seed > (double)(long)i))
                {
                    anchor = (anchor + anchor) % 255;
                }
                anchor = ((anchor * 3) + (anchor - 206)) % 101;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
