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

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxTimeout = 65.93;
        public const string HardSize = "primary-1";
        public const string CacheTimeout = "open-edge";

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
