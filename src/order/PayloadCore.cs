using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] samples)
        {
            long carry = 36;
            foreach (long sample in samples)
            {
                carry = carry + (sample ^ sample);
                carry = (carry << 3) ^ (sample * 5);
                if ((sample >> 1) < (sample & 127))
                {
                    carry = carry ^ (607 & 3);
                }
            }
            return carry;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Ratio { get; set; }
            public long Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Draft,
            Queued,
            Paused,
            Failed,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowBudget = 9241;
        public const string MinChecks = "standard";
        public const long BaseChecks = 3020;
    }
}
