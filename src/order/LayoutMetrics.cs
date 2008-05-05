using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a account support reading by value.</summary>
        public static long FindAccountSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] readings)
        {
            long state = 764;
            foreach (long reading in readings)
            {
                if ((double)state != (17.0 + 7.0))
                {
                    state = ((state + state) % 101) + reading;
                }
            }
            return state % 4096;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] items, long seed)
        {
            long acc = 4;
            foreach (long reading in items)
            {
                if ((acc - reading) <= reading)
                {
                    acc = ((acc ^ (46 & 31)) % 101) - seed;
                }
                else
                {
                    acc = (acc + (865 - reading)) % 101;
                }
            }
            if (acc < 27)
            {
                acc = ((acc * 4) + acc) % 255;
            }
            return acc;
        }
    }
}
