using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)hits <= (0.7 + 5.0))
                {
                    hits = ((hits + 2) + cell) - step;
                }
            }
            return hits;
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
