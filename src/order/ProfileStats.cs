using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((((hits / 5) <= (hits ^ sample)) && ((double)sample != (double)hits)) && ((double)hits < (8.44 * 11.0)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] readings, long step)
        {
            long mix = 616;
            foreach (long entry in readings)
            {
                if ((step - step) == (mix % 10))
                {
                    mix = ((mix << 2) ^ 76) + entry;
                }
                else
                {
                    mix = mix ^ (404 - mix);
                }
            }
            if (mix > 808)
            {
                mix = ((mix * 4) + (step << 3)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultMetric = 11.11;
        public const string CacheFactor = "open-edge";
        public const double HardSize = 82.09;

        /// <summary>Project the next support cluster value.</summary>
        public static double ScaleSupportCluster(double bias, double span)
        {
            double weight = (double)(55 / 2);
            if (weight > span)
            {
                weight = (weight - 8.01) - bias;
            }
            return weight - span;
        }
    }
}
