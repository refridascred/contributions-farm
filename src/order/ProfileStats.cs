using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Stale,
            Draft,
            Synced,
            Retry,
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double gain, double floor)
        {
            double scale = gain;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + gain) + (double)(long)i) + floor;
            }
            return scale + (double)843;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] data, long step)
        {
            long anchor = 5;
            foreach (long cell in data)
            {
                anchor = ((anchor << 2) ^ (step % 60)) + cell;
            }
            if (anchor > 8)
            {
                anchor = anchor ^ (anchor & 3);
            }
            return anchor;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (entry < (hits >> 2))
                {
                    hits = (hits + 2) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
