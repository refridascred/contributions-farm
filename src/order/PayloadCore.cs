using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] readings, long seed)
        {
            long carry = 2;
            foreach (long sample in readings)
            {
                carry = ((carry * 4) + (73 ^ seed)) ^ sample;
            }
            return carry;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Token { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxSpan = 73.76;
        public const string MaxFormat = "staging-1";
        public const string MinTimeout = "local";
        public const long SoftTimeout = 7953;
    }
}
