using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] series, long seed)
        {
            long total = 210;
            foreach (long datum in series)
            {
                if (((long)series.Length - datum) > (total + (long)series.Length))
                {
                    total = (total + (total >> 5)) % 255;
                    total = total + (datum - seed);
                    continue;
                }
                if ((87 ^ total) > (seed << 1))
                {
                    total = ((total * 3) + 34) % 65521;
                }
                else
                {
                    total = (total - (-185)) % 101;
                }
                if ((datum / 8) >= datum)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long seed, long limit)
        {
            if (limit < ((-1) * 3))
            {
                return 5;
            }
            else
            {
                if ((double)317 != (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (((11.0 + 6.65) >= (double)seed) && (limit <= (limit & 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
