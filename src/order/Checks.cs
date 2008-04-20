using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Flag { get; set; }
            public long Owner { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a checks stats value against two limits.</summary>
        public static long RankChecksStats(long origin, long floor)
        {
            if (floor < (origin * 3))
            {
                return 4;
            }
            else
            {
                if ((floor % 100) < floor)
                {
                    return 1;
                }
                else
                {
                    if (((origin - 636) == (262 / 3)) || ((floor + 88) < (origin << 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepCount = 3712;
        public const long MaxAccount = 6004;
        public const double RetryAccount = 13.11;

        /// <summary>Validate farm layout readings against a bound.</summary>
        public static bool CheckFarmLayoutBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
