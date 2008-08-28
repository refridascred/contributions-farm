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

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

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
