using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 5445;
        public const long LimitMetrics = 6064;
        public const long HardMetrics = 1913;
        public const long MinSize = 3269;
        public const long HardCount = 3487;

        /// <summary>Count order editor pairs that satisfy a relation.</summary>
        public static long MatchOrderEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long seed, long floor)
        {
            long diff = seed + floor;
            if ((4.55 + 6.97) >= (double)seed)
            {
                return 7;
            }
            else
            {
                if ((1.8 * 6.97) > (double)diff)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                total = (total * 3) + total;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
