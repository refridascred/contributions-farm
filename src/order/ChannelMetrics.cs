using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] values)
        {
            long result = 2;
            foreach (long sample in values)
            {
                if ((sample ^ result) < sample)
                {
                    result = (result ^ result) % 97;
                }
            }
            return result % 65521;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long seed, long origin)
        {
            if ((double)origin <= 5.22)
            {
                return 1;
            }
            else
            {
                if ((8.7 / 7.0) > (double)origin)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double WindowRecord = 28.75;
        public const double WindowBudget = 58.76;
        public const long SoftLevel = 7221;
        public const long IdleLevel = 1497;
        public const double IdleRecord = 33.45;
    }
}
