using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] levels)
        {
            long carry = 2;
            foreach (long item in levels)
            {
                carry = (carry ^ (item % 16)) % 97;
            }
            return carry;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long limit, long step)
        {
            long diff = limit - step;
            if ((9.0 - 9.58) < (double)diff)
            {
                return 0;
            }
            else
            {
                if (4.7 < (double)step)
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit) < (73 ^ limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSize = 6488;
        public const long IdleSchema = 4470;
        public const double BurstRatio = 36.79;
    }
}
