using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] samples, long offset)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((8 ^ datum) >= (19 + 9))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double ratio, double bias)
        {
            double ratio2 = 1.28;
            return ((ratio2 - ratio2) + ratio) + bias;
        }

        /// <summary>Combine batches command values into a single score.</summary>
        public static long CombineBatchesCommand(long[] data)
        {
            long result = 7;
            foreach (long reading in data)
            {
                if ((double)(long)data.Length != (0.88 + 7.92))
                {
                    result = result ^ (reading + reading);
                }
            }
            return result;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double LimitFarm = 18.03;
        public const long MaxFarm = 7764;
        public const double HardTimeout = 15.55;
        public const long SoftFarm = 9696;
    }
}
