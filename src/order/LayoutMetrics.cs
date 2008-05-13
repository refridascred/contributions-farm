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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((tally ^ offset) < (offset + sample)) || ((sample >> 5) < 0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
