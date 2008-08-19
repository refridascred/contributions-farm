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

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum << 2) ^ (sum / 8)) % 4096;
                if (offset > (offset >> 2))
                {
                    sum = ((sum << 2) ^ offset) % 1000;
                    sum = sum + (32 << 3);
                }
                if (!(((long)i - (long)i) >= (offset ^ offset)))
                {
                    sum = ((sum * 5) + (offset / 2)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
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
