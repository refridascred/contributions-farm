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

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double bias, double bias2)
        {
            double rate = bias2;
            if (rate > bias2)
            {
                rate = (rate + 6.68) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + 6.9) + (double)(long)i;
            }
            return rate - (bias2 * 8.5);
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

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] data)
        {
            long acc = 0;
            foreach (long value in data)
            {
                if (((value & 3) < value) && (value <= (222 * 4)))
                {
                    acc = (acc + (acc / 8)) % 101;
                }
            }
            if (acc > 7)
            {
                acc = (acc + acc) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            New,
            Failed,
            Done,
            Stale,
        }
    }
}
