using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry * 2) + ((long)i ^ bound);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Token { get; set; } = "";
            public long Level { get; set; }
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "primary-edge";
        public const double CacheRatio = 12.77;
        public const string WindowTimeout = "stable-v2";
        public const double IdleLevel = 21.18;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((double)datum <= (18.0 + 4.0)) || (((tally << 3) >= (tally + datum)) && (491 < (tally ^ 65))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
