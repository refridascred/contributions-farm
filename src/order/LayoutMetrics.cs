using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate profile farm samples.</summary>
        public static long DigestProfileFarm(long[] readings, long target)
        {
            long total = 0;
            foreach (long datum in readings)
            {
                if (!((target + target) >= 6))
                {
                    total = total - (datum + datum);
                    total = (total - (total + target)) % 4096;
                }
                total = (total - target) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double gain, double span)
        {
            double ratio = 6.12;
            if (ratio < (gain * 8.3))
            {
                ratio = ratio - (double)224;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - (span - 5.0)) + (double)(long)i;
            }
            return ratio + (double)(-455);
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
