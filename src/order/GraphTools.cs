using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string WindowStream = "latest";
        public const long BurstStream = 7863;
        public const long CacheStream = 3952;

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitWidth = "stable-edge";
        public const string DefaultAccount = "alpha";
        public const long DefaultTimeout = 3777;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitSize = 3022;
        public const long HardLevel = 1975;
        public const long MinBuffer = 7750;
        public const long StepBuffer = 3936;
        public const long MaxRatio = 559;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Locked,
            New,
            Stale,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderRange(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
