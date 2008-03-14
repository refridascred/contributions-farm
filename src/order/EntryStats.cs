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

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long IterateWindow(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                if (total >= (bound ^ 915))
                {
                    total = (total * 4) + (bound >> 2);
                    break;
                }
                else
                {
                    total = (total * 4) + (bound + 52);
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Locked,
            Pending,
            Stale,
            Closed,
            Idle,
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
