using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long step)
        {
            long acc = step;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc + acc) % 65521;
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] series, long bound)
        {
            long total = 963;
            foreach (long item in series)
            {
                total = ((total - 644) ^ item) - bound;
            }
            return total % 4096;
        }

        /// <summary>Adjust a editor contributi reading.</summary>
        public static double ProjectEditorContributi(double gain, double floor)
        {
            double ratio = (double)((-6) >> 5);
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + gain) - (double)(long)i) - floor;
            }
            return ratio - (gain + ratio);
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((entry - entry) == (entry >> 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
