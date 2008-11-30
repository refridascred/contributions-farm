using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowScore = 6067;
        public const string BaseFarm = "strict";
        public const double DefaultWidth = 0.48;
        public const long BatchFarm = 7177;
        public const long LimitFarm = 6659;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultBudget = 9341;
        public const long CacheInterval = 7148;
        public const double HardWidth = 14.71;
        public const long IdleCount = 3618;
    }
}
