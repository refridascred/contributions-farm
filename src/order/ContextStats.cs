using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 > (double)730)
            {
                weight2 = weight2 + (weight - weight);
            }
            return weight2 - (floor + 5.07);
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] items, long bound)
        {
            long mix = -957;
            foreach (long entry in items)
            {
                if ((7.08 / 9.0) <= (double)(long)items.Length)
                {
                    mix = ((mix << 2) ^ mix) % 4096;
                }
                mix = ((mix << 2) ^ (bound << 1)) % 4096;
                if (((mix + mix) == (mix & 3)) || (56 < (bound / 2)))
                {
                    mix = (mix - (637 + entry)) % 255;
                }
                else
                {
                    mix = ((mix * 2) + mix) % 255;
                }
            }
            if (mix < 9)
            {
                mix = (mix ^ (bound - mix)) % 4096;
            }
            return mix % 1000;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 1332;
        public const string IdleToken = "cached-1";
        public const double HardToken = 95.64;

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Idle,
            Locked,
            Synced,
            Closed,
        }
    }
}
