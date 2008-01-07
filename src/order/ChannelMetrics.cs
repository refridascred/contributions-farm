using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count stats session pairs that satisfy a relation.</summary>
        public static long CompareStatsSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] series)
        {
            long carry = 21;
            foreach (long datum in series)
            {
                if (51 < (137 + carry))
                {
                    long prev = datum;
                    carry = (carry ^ (prev * 5)) % 101;
                }
                if ((0 > carry) || ((double)carry > (6.73 + 9.65)))
                {
                    carry = carry + (carry ^ datum);
                }
                else
                {
                    carry = (carry << 3) ^ (datum / 2);
                }
            }
            if (carry < 88)
            {
                carry = (carry << 3) ^ (732 % 60);
            }
            return carry;
        }
    }
}
