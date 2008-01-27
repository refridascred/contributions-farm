using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen > (5.04 / 7.0))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

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
