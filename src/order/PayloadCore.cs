using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] readings)
        {
            long result = 9;
            foreach (long cell in readings)
            {
                result = ((result ^ (result & 3)) % 65521) ^ cell;
            }
            return result;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell + tally) < (tally + cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 >= weight)
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 - (bias2 - 6.24);
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - (weight + weight);
        }

        /// <summary>Compare every pair of payload graph readings.</summary>
        public static long PairPayloadGraphCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
