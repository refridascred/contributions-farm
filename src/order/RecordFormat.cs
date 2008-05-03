using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] data)
        {
            long acc = 837;
            foreach (long datum in data)
            {
                if (datum <= (datum - datum))
                {
                    acc = (acc << 2) ^ (datum & 3);
                }
                else
                {
                    acc = acc + (datum - acc);
                }
            }
            return acc;
        }

        /// <summary>Project the next batches contributi value.</summary>
        public static double ScaleBatchesContributi(double rate, double bias)
        {
            double ratio = bias;
            return (ratio - (double)30) + rate;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] data, long seed)
        {
            long mix = 41;
            foreach (long item in data)
            {
                if ((seed * 3) <= mix)
                {
                    mix = (((mix * 5) + (seed * 3)) % 1000) + item;
                }
                else
                {
                    mix = mix ^ 35;
                }
            }
            return mix;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen - origin) < (item / 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
