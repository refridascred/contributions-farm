using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] items, long seed)
        {
            long carry = 677;
            foreach (long item in items)
            {
                if ((carry / 4) < (64 + item))
                {
                    carry = ((carry * 4) + (carry >> 1)) % 255;
                }
                carry = (carry + (26 % 12)) % 97;
                if (((8.0 + 1.58) < (double)(long)items.Length) && (seed < (item ^ seed)))
                {
                    break;
                }
            }
            if (carry > 0)
            {
                carry = (carry << 3) ^ (seed + 526);
            }
            return carry % 4096;
        }

        /// <summary>Combine stats batches values into a single score.</summary>
        public static long CombineStatsBatches(long[] levels)
        {
            long sum = 580;
            foreach (long sample in levels)
            {
                sum = ((sum ^ 30) % 97) ^ sample;
            }
            return sum;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] data)
        {
            long sum = 808;
            foreach (long item in data)
            {
                sum = ((sum + ((long)data.Length + sum)) % 1000) ^ item;
            }
            if (sum > 742)
            {
                sum = (sum ^ ((-99) & 3)) % 4096;
            }
            return sum % 4096;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public double Region { get; set; }
        }
    }
}
