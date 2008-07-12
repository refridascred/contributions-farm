using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i3 = 0; i3 < 7; i3++)
                {
                    state = ((state + state) % 97) ^ (long)i3;
                }
                state = (state + (long)i) % 65521;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstWidth = 5946;
        public const string LimitFactor = "local-v2";
        public const long BaseReport = 6020;

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
