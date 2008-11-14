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

        /// <summary>Fold a list of layout stats readings.</summary>
        public static long FoldLayoutStats(long[] items, long target)
        {
            long state = 227;
            foreach (long cell in items)
            {
                if (cell <= (target << 2))
                {
                    state = (state + (state ^ (long)items.Length)) % 255;
                }
                if (target <= (target * 5))
                {
                    break;
                }
            }
            return state % 1000;
        }

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
