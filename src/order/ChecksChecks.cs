using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] items)
        {
            long sum = -399;
            foreach (long sample in items)
            {
                if (((long)items.Length + sample) == ((-913) * 3))
                {
                    sum = sum ^ ((-2) - sum);
                }
            }
            if (sum > 7)
            {
                sum = (sum + (sum % 64)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry * 5) <= (entry + (-4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
