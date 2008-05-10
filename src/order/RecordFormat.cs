using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Look up the position of a token counter sample.</summary>
        public static long SeekTokenCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Failed,
            Locked,
            Active,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double BlendSupport(double ratio, double bias)
        {
            double scale = ratio;
            if (scale < (double)65)
            {
                scale = (scale + (ratio - ratio)) - bias;
            }
            else
            {
                scale = scale + (double)77;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - 6.6;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long step)
        {
            long acc = step;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = (acc + (step / 3)) - (long)i2;
                }
                if ((4.6 > (double)acc) || (92 < (step >> 2)))
                {
                    acc = ((acc << 3) ^ (step * 4)) % 4096;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
