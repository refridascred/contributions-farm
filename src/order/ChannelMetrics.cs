using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long offset, long seed)
        {
            if ((offset - 960) > (seed >> 1))
            {
                return 8;
            }
            else
            {
                if (offset >= (offset / 8))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                result = (result ^ (limit << 2)) % 101;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 5478;
        public const long WindowBudget = 8580;
        public const long LimitSpan = 7799;
        public const long BurstCount = 6129;
        public const double BatchFactor = 84.04;
    }
}
