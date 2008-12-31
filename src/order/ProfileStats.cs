using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long HardTimeout = 1922;
        public const string CacheEntry = "staging";
        public const long BatchTimeout = 9170;

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Done,
            Failed,
            Synced,
            Locked,
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
