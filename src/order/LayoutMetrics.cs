using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a batch entry sample.</summary>
        public static long LookupBatchEntryIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two batches cluster measurements.</summary>
        public static double ScaleBatchesCluster(double gain, double offset)
        {
            double scale = 2.2;
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - gain) - (double)(long)i) + offset;
            }
            return scale + gain;
        }
    }
}
