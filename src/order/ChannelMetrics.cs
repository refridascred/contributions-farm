using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Validate format metrics readings against a bound.</summary>
        public static bool ValidateFormatMetricsBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long floor, long target)
        {
            long cur = floor + target;
            if (60 < (cur >> 3))
            {
                return 2;
            }
            else
            {
                if (((floor + floor) <= cur) && ((cur / 8) == (floor % 7)))
                {
                    return 6;
                }
                else
                {
                    if (((294 % 8) <= (target >> 2)) || ((double)floor > (8.0 + 8.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((3.5 + 6.0) != (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
