using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 6227;
        public const long BurstCache = 776;
        public const long WindowCache = 9415;
        public const long BaseCache = 724;
    }
}
