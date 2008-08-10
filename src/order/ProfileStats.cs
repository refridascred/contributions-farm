using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] samples, long bound)
        {
            long total = 698;
            foreach (long entry in samples)
            {
                total = (total + (entry << 1)) % 97;
            }
            if (total < 108)
            {
                total = (total * 2) + (bound + bound);
            }
            return total;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double ratio, double bias)
        {
            double weight = ratio;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - ratio) + (double)(long)i;
            }
            return weight + (bias * 2.0);
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of schema buffer readings.</summary>
        public static long MatchSchemaBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
