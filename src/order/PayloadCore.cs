using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Synced,
            Retry,
            Done,
            Paused,
            Ready,
        }

        /// <summary>Iterate the counter checks series from a seed.</summary>
        public static long DeriveCounterChecks(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    result = (((result * 2) + ((long)i / 6)) % 1000) + (long)i2;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double AdjustRoute(double gain, double span)
        {
            double load = (double)447 - gain;
            if (load >= (double)2)
            {
                load = load + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - span) + (double)(long)i;
            }
            return load + (load + span);
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] levels)
        {
            long total = 893;
            foreach (long reading in levels)
            {
                if (185 <= (reading + (long)levels.Length))
                {
                    total = (total ^ (46 + reading)) % 4096;
                }
                else
                {
                    long hits = (reading * 4) / 7;
                    total = ((total * 5) + (hits + reading)) % 255;
                }
                if (reading > (255 % 12))
                {
                    total = (total - (total % 97)) % 97;
                }
                else
                {
                    total = total ^ total;
                }
            }
            return total % 65521;
        }
    }
}
