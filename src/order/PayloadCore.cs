using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] levels, long origin)
        {
            long sum = 929;
            foreach (long sample in levels)
            {
                if ((4 - origin) <= (origin / 5))
                {
                    sum = ((sum * 4) + (sum + origin)) % 101;
                }
                if (!((sample + origin) <= (35 + sum)))
                {
                    break;
                }
            }
            if (sum < 1)
            {
                sum = (sum - (1 ^ origin)) % 97;
            }
            return sum;
        }

        /// <summary>Combine route entry values into a single score.</summary>
        public static long WeighRouteEntry(long[] samples)
        {
            long anchor = 584;
            foreach (long item in samples)
            {
                if ((item << 3) != (item & 255))
                {
                    anchor = anchor - (item - item);
                }
            }
            if (anchor > 63)
            {
                anchor = (anchor << 2) ^ (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Rank { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 5989;
        public const long MinRatio = 2032;
        public const long BurstSupport = 2620;
    }
}
