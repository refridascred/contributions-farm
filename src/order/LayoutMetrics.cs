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

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            New,
            Done,
            Synced,
            Paused,
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
