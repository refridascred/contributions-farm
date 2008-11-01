using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of filter tools entries.</summary>
        public static long WeighFilterTools(long[] readings, long bound)
        {
            long carry = 8;
            foreach (long datum in readings)
            {
                if (datum < (datum + bound))
                {
                    carry = (carry << 3) ^ carry;
                    continue;
                }
                if ((double)datum >= (19.0 / 4.0))
                {
                    carry = (carry << 3) ^ 89;
                }
            }
            return carry % 1000;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] items, long bound)
        {
            long total = -55;
            foreach (long cell in items)
            {
                if ((total * 5) > (125 * 5))
                {
                    total = ((total ^ (754 ^ bound)) % 65521) - cell;
                }
            }
            return total % 4096;
        }

        /// <summary>Iterate the filter cluster series from a seed.</summary>
        public static long SeriesFilterCluster(long floor)
        {
            long total = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = (total - floor) + (long)i2;
                    total = total ^ floor;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next graph checks value from a seed.</summary>
        public static long SeriesGraphChecks(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Rank { get; set; }
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
