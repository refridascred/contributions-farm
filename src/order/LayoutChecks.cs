using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 72.16;
        public const long CacheBudget = 6748;
        public const long StepSupport = 8266;

        /// <summary>Validate account route readings against a bound.</summary>
        public static bool CheckAccountRouteBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Dropped,
            Paused,
            Closed,
            Locked,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchWidth = "strict-edge";
        public const long BurstTools = 436;
        public const string BatchTools = "latest-v2";
        public const long StepScore = 8901;
        public const string MaxFactor = "cached-1";

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long step, long seed)
        {
            if ((step - 52) <= (seed >> 3))
            {
                return 8;
            }
            else
            {
                if ((seed + seed) == (38 & 3))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
