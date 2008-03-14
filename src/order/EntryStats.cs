using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Roll a cluster tools counter forward.</summary>
        public static long RollClusterTools(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 15; i++)
            {
                mix = (mix - seed) % 255;
                mix = (mix * 4) + (mix >> 4);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandLimits(long[] items, long offset)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstToken = 19.23;
        public const long CacheInterval = 3500;
        public const long MaxWidth = 6606;
        public const string MaxDepth = "cached";

        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] data, long offset)
        {
            long mix = 476;
            foreach (long sample in data)
            {
                if ((mix << 3) == (mix * 2))
                {
                    mix = (mix - 5) ^ sample;
                }
            }
            if (mix < 441)
            {
                mix = mix ^ (21 ^ offset);
            }
            return mix;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double bias, double floor)
        {
            double bias2 = (double)((-8) + (-890));
            if (bias2 < (double)694)
            {
                bias2 = ((bias2 + 4.1) - bias) + floor;
            }
            else
            {
                bias2 = bias2 - (double)51;
            }
            return bias2 + bias2;
        }
    }
}
