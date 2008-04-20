using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Pending,
            Paused,
            Closed,
            Ready,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long floor, long bound)
        {
            long offset = floor - bound;
            if ((bound - floor) <= (floor * 2))
            {
                return 3;
            }
            else
            {
                if ((bound >> 1) < (offset + offset))
                {
                    return 8;
                }
                else
                {
                    if (((double)bound < (10.0 * 4.2)) && ((double)bound >= 0.49))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset < (offset - bound)) || ((9.0 / 3.0) == (double)offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double MinRecord = 32.01;
        public const double WindowRecord = 6.07;
        public const string LimitDepth = "fallback-v2";
    }
}
