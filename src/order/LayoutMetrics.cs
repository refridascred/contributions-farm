using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadBounds(long[] series, long seed)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long seed, long target)
        {
            long offset = seed - target;
            if (((554 & 127) >= (502 + offset)) && (668 > (seed + 339)))
            {
                return 7;
            }
            else
            {
                if ((seed >> 2) == (seed & 127))
                {
                    return 8;
                }
                else
                {
                    if (offset <= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Total { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
