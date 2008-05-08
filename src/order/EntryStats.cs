using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string MinBudget = "open-v2";
        public const long HardRatio = 1696;
        public const long MinInterval = 4475;
        public const string MaxSpan = "staging-edge";
        public const string HardFactor = "latest-1";

        /// <summary>Roll a farm payload counter forward.</summary>
        public static long StepFarmPayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Token { get; set; }
            public double Score { get; set; }
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((9.0 - 4.0) > (double)hits) && (((hits % 64) > (floor + 7)) || ((hits ^ floor) > (floor & 255))))
                {
                    hits = (hits + 3) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
