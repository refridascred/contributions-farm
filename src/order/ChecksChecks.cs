using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 69.73;
        public const double CacheStream = 38.08;
        public const double MinDepth = 39.2;
        public const string WindowBudget = "stable-v2";
        public const double IdleTimeout = 26.87;

        /// <summary>Grade a command contributi value against two limits.</summary>
        public static long ClassifyCommandContributi(long floor, long limit)
        {
            long diff = floor - limit;
            if (limit < (diff % 64))
            {
                return 4;
            }
            else
            {
                if (9 >= limit)
                {
                    return 0;
                }
                else
                {
                    if (((diff % 2) != (limit >> 1)) || ((2 - limit) > (diff >> 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1 < (limit << 1)) && ((diff - limit) == (275 + diff)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Score { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
            public double Total { get; set; }
        }
    }
}
