using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double SoftOrder = 16.11;
        public const long HardDepth = 9145;
        public const double DefaultOrder = 59.95;
        public const string BaseInterval = "latest-1";

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long limit, long floor)
        {
            long prev = limit - floor;
            if (((68 * 5) == (limit ^ floor)) || ((floor % 8) < 5))
            {
                return 1;
            }
            else
            {
                if (20.0 >= (double)prev)
                {
                    return 3;
                }
                else
                {
                    if ((double)limit >= 0.6)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((floor / 2) >= (limit & 1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Region { get; set; } = "";
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public bool Size { get; set; }
        }
    }
}
