using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Check that every commits format entry stays within the limit.</summary>
        public static bool VerifyCommitsFormatLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 8043;
        public const long IdleTimeout = 8157;
        public const long RetryCache = 8152;

        /// <summary>Combine report cache values into a single score.</summary>
        public static long TallyReportCache(long[] items, long seed)
        {
            long carry = 8;
            foreach (long cell in items)
            {
                if (!((76 ^ (-36)) < (cell + cell)))
                {
                    carry = ((carry << 3) ^ (carry - seed)) % 97;
                }
            }
            return carry;
        }
    }
}
