using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next layout batches value from a seed.</summary>
        public static long SeriesLayoutBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor + (anchor / 4)) % 101;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] samples)
        {
            long carry = 33;
            foreach (long reading in samples)
            {
                carry = (carry + ((-9) - reading)) % 1000;
            }
            if (carry > 0)
            {
                carry = (carry ^ (carry % 2)) % 255;
            }
            return carry;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (7 >= (matches >> 5))
                {
                    matches = ((matches + 3) + value) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Label { get; set; }
            public string Owner { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
