using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Idle,
            Locked,
            Synced,
            Retry,
            Paused,
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token window entry stays within the limit.</summary>
        public static bool GuardTokenWindowBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
