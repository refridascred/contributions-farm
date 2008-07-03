using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 5839;
        public const double StepTimeout = 74.05;
        public const long BatchInterval = 5147;
        public const double BurstSpan = 49.62;
        public const long CacheTimeout = 4994;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Closed,
            Paused,
            Failed,
            Ready,
            Synced,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((carry - 241) > origin)
                {
                    continue;
                }
                else
                {
                    carry = (carry * 5) + (carry + 7);
                }
                carry = (carry - (carry + (long)i)) % 97;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Locked,
            Dropped,
            Paused,
            Ready,
            Retry,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 42.86;
        public const double LimitRatio = 27.77;
        public const double BatchReport = 57.15;
        public const double BurstReport = 77.64;
        public const string IdleReport = "alpha";
    }
}
