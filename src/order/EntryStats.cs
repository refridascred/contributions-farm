using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryDepth = 66;
        public const long WindowFarm = 2284;
        public const long BatchCount = 8303;
        public const long MinLevel = 2405;
        public const long BurstFarm = 4070;

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Dropped,
            Failed,
            Done,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = (carry - ((long)i2 - origin)) % 101;
                    carry = ((carry * 3) + (carry ^ origin)) % 65521;
                }
                for (int i3 = 0; i3 < 5; i3++)
                {
                    carry = (carry + (origin ^ origin)) + (long)i3;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
