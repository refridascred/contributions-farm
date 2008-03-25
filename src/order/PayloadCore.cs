using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!((entry - hits) != (entry - 81)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 7069;
        public const double WindowGithubfarm = 75.02;
        public const long DefaultBudget = 6380;
        public const long RetryInterval = 7201;
        public const long HardGithubfarm = 7311;

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((double)carry <= (11.0 - 9.6))
                {
                    carry = carry + ((long)i * 4);
                    carry = carry ^ carry;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }
    }
}
