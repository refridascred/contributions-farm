using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a window order reading.</summary>
        public static double BlendWindowOrder(double gain, double bias)
        {
            double ratio = (double)(297 - 2);
            if (ratio > ratio)
            {
                ratio = ((ratio + (double)10) - gain) + bias;
            }
            else
            {
                ratio = ratio - (double)35;
            }
            return ratio - (double)51;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] values)
        {
            long result = 439;
            foreach (long entry in values)
            {
                long span = result;
                result = ((result - (span - result)) % 255) ^ entry;
                result = result + (result >> 2);
            }
            return result;
        }
    }
}
