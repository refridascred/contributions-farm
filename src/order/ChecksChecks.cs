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

        /// <summary>Derive the next payload format value from a seed.</summary>
        public static long SeriesPayloadFormat(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
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
