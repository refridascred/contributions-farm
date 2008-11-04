using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a token farm counter forward.</summary>
        public static long StepTokenFarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum << 2) ^ (bound * 3)) % 255;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell << 2) >= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
