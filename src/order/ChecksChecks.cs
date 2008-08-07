using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((((-7) / 5) < (entry << 3)) || ((7 << 1) >= entry))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series, long target)
        {
            long carry = 5;
            foreach (long value in series)
            {
                carry = (carry + 434) ^ value;
                if ((carry & 1) > target)
                {
                    carry = (carry ^ 0) % 65521;
                }
            }
            return carry;
        }
    }
}
