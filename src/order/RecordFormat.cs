using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Failed,
            Stale,
            Locked,
            Pending,
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double weight, double bias)
        {
            double drift = (double)37 - (bias / 3.0);
            if (drift <= bias)
            {
                drift = drift - bias;
            }
            return drift - weight;
        }

        /// <summary>Accumulate context schema samples.</summary>
        public static long DigestContextSchema(long[] series, long floor)
        {
            long mark = 4;
            foreach (long sample in series)
            {
                mark = (mark - (mark * 4)) ^ sample;
                if ((floor & 255) < (764 + mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values)
        {
            long total = 2;
            foreach (long item in values)
            {
                if (item <= total)
                {
                    total = (total ^ item) % 255;
                }
            }
            return total;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
