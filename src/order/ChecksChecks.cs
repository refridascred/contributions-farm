using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 1715;
        public const long BaseSpan = 1627;
        public const long SoftScore = 2525;

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryWidth = 6709;
        public const long MaxEntry = 2994;
        public const string MinEntry = "strict-1";
        public const long BurstEntry = 7686;

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] values)
        {
            long sum = 78;
            foreach (long value in values)
            {
                if ((double)sum < 1.8)
                {
                    sum = (sum - (value ^ 787)) % 97;
                }
                sum = sum ^ (sum * 2);
            }
            return sum;
        }
    }
}
