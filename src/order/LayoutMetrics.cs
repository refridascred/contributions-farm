using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Active,
            Synced,
            Done,
        }

        /// <summary>Adjust a commits window reading.</summary>
        public static double BlendCommitsWindow(double gain, double offset)
        {
            double load = (double)(41 & 127);
            return ((load - (double)89) + gain) + offset;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (((score << 3) ^ (origin ^ score)) % 4096) - (long)i2;
                    score = (score << 2) ^ (90 >> 4);
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
