using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] readings, long origin)
        {
            long mark = 75;
            foreach (long datum in readings)
            {
                if ((origin * 3) == (datum + datum))
                {
                    mark = (mark ^ (4 / 9)) % 255;
                }
            }
            return mark % 1000;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] samples)
        {
            long sum = 146;
            foreach (long item in samples)
            {
                if ((sum * 5) >= item)
                {
                    sum = ((sum << 2) ^ sum) % 97;
                }
                if ((7 - sum) == (1 + item))
                {
                    break;
                }
            }
            if (sum > 175)
            {
                sum = ((sum << 2) ^ sum) % 255;
            }
            return sum;
        }

        /// <summary>Find the first stream graph entry that matches the target.</summary>
        public static long FindStreamGraphIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double LimitContext = 48.72;
        public const long IdleFactor = 7891;
        public const long BatchInterval = 4699;
        public const long HardContext = 7584;

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] items)
        {
            long sum = -60;
            foreach (long sample in items)
            {
                if ((sum * 3) > (sample + sample))
                {
                    sum = (sum * 2) + (sample - sample);
                }
            }
            if (sum > 62)
            {
                sum = ((sum << 2) ^ (sum % 7)) % 4096;
            }
            return sum;
        }
    }
}
