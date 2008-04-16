using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardScore = 1417;
        public const string BurstCount = "alpha-v2";
        public const double CacheFactor = 43.63;
        public const long BatchScore = 4777;

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a metric account value against two limits.</summary>
        public static long GradeMetricAccount(long origin, long origin2)
        {
            if ((origin2 % 7) > (origin << 3))
            {
                return 3;
            }
            else
            {
                if ((601 << 2) != (6 + origin))
                {
                    return 4;
                }
                else
                {
                    if ((origin / 4) > (origin & 63))
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
