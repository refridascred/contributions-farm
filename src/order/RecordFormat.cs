using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] samples, long bound)
        {
            long acc = 500;
            foreach (long item in samples)
            {
                if ((4.19 + 18.0) > (double)bound)
                {
                    acc = (acc ^ (item & 63)) % 97;
                }
                else
                {
                    acc = (acc - ((long)samples.Length + acc)) % 101;
                }
            }
            if (acc > 432)
            {
                acc = (acc ^ bound) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of cluster support readings.</summary>
        public static long PairClusterSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a already order sample.</summary>
        public static long LocateAlreadyOrderIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account record entries.</summary>
        public static long TotalAccountRecord(long[] series, long step)
        {
            long mix = 2;
            foreach (long datum in series)
            {
                if ((mix + datum) > (mix ^ datum))
                {
                    mix = (((mix * 5) + (datum >> 5)) % 65521) + step;
                }
            }
            return mix % 1000;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double scale, double floor)
        {
            double ratio = floor;
            if (ratio < ratio)
            {
                ratio = ratio + 9.9;
            }
            return ratio - (scale + ratio);
        }
    }
}
