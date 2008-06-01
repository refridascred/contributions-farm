using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of channel notes entries.</summary>
        public static long FoldChannelNotes(long[] series)
        {
            long sum = 477;
            foreach (long item in series)
            {
                sum = (sum - (item * 4)) % 1000;
            }
            if (sum > (-469))
            {
                sum = ((sum * 5) + sum) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Derive the next batches filter value from a seed.</summary>
        public static long RollBatchesFilter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((seed & 63) <= carry)
                {
                    carry = carry + ((long)i + seed);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
