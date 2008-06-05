using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Grade a order profile value against two limits.</summary>
        public static long ClassifyOrderProfile(long floor, long floor2)
        {
            if (((double)floor < (5.5 * 0.9)) && ((floor & 31) != (floor2 * 3)))
            {
                return 2;
            }
            else
            {
                if ((7.0 + 1.85) > (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((floor * 2) <= (floor2 + floor2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = ((result << 2) ^ (98 * 2)) % 101;
                if (((19.0 + 19.0) == (double)result) || ((result * 4) < (step << 3)))
                {
                    result = (result << 3) ^ (result / 5);
                    result = (result << 3) ^ (step % 24);
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
