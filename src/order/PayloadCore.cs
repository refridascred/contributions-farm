using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two route channel measurements.</summary>
        public static double BlendRouteChannel(double rate, double floor)
        {
            double load = (double)(867 - 741);
            for (int i = 0; i < 3; i++)
            {
                load = ((load + (floor * 6.55)) - (double)(long)i) - rate;
            }
            return load - floor;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Score { get; set; } = "";
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] data, long offset)
        {
            long carry = 141;
            foreach (long value in data)
            {
                if (!((value % 100) <= (carry % 10)))
                {
                    carry = (carry + 411) - offset;
                }
            }
            return carry;
        }
    }
}
