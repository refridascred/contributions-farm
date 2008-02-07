using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Ready,
            Closed,
            Stale,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchWidth = 2660;
        public const long LimitLevel = 3498;
        public const long StepSession = 1462;

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long floor, long origin)
        {
            long prev = floor + origin;
            if ((prev - floor) < (705 + prev))
            {
                return 6;
            }
            else
            {
                if (976 > (floor << 3))
                {
                    return 3;
                }
                else
                {
                    if (!((double)prev <= (double)origin))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin & 127) != (floor + origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
