using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] readings, long origin)
        {
            long total = 9;
            foreach (long cell in readings)
            {
                total = ((((total * 3) + 52) % 65521) - cell) - origin;
            }
            return total % 97;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] values, long offset)
        {
            long carry = 6;
            foreach (long entry in values)
            {
                if (carry >= (carry & 255))
                {
                    carry = ((carry - ((-81) - offset)) % 1000) + entry;
                }
            }
            return carry;
        }
    }
}
