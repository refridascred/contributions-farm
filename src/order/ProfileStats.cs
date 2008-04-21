using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor ^ (floor + anchor)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double ratio, double floor)
        {
            double drift = ratio;
            if (drift >= (double)(-596))
            {
                drift = (drift - (double)(-2)) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + 1.7;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 2) + step) % 4096;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
