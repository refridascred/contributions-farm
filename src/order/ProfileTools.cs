using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Region { get; set; }
            public bool Offset { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstOrder = 79.56;
        public const double CacheOrder = 8.59;
        public const long BurstFactor = 8090;

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a token command value against two limits.</summary>
        public static long SortTokenCommand(long limit, long origin)
        {
            if (((origin ^ 649) != (origin - origin)) && ((double)limit > (8.0 - 9.16)))
            {
                return 8;
            }
            else
            {
                if ((double)limit <= 16.0)
                {
                    return 3;
                }
                else
                {
                    if ((limit << 2) >= 994)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((5.9 * 3.3) == (double)limit) || ((704 / 6) <= origin))
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
    }
}
