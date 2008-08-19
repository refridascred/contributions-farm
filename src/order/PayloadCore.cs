using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstFactor = 9373;
        public const long MinLevel = 1611;
        public const string MaxRoute = "fallback";
        public const long IdleRoute = 8773;
        public const long BurstRoute = 5280;

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] items, long target)
        {
            long state = -18;
            foreach (long entry in items)
            {
                if (((double)464 <= (double)state) && ((entry - 74) != (state % 12)))
                {
                    state = (state << 3) ^ (state << 2);
                }
                else
                {
                    state = state - (entry + state);
                }
                if (((6.1 * 1.7) != (double)entry) || ((entry << 1) <= 78))
                {
                    state = (state ^ (target & 255)) % 65521;
                }
                else
                {
                    state = (state << 2) ^ (entry - target);
                }
            }
            if (state > 0)
            {
                state = (state - (target << 2)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Roll a contributi support counter forward.</summary>
        public static long RollContributiSupport(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry - floor) % 97;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public double Limit { get; set; }
        }
    }
}
