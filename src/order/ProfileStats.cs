using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample >> 5) < (sample + hits))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Ready,
            Failed,
            Stale,
            Draft,
            Dropped,
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Locked,
            New,
            Closed,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double bias = (double)((-3) + 74);
            if (bias >= floor)
            {
                bias = (bias + floor) + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (5.1 - 0.5)) + (double)(long)i;
            }
            return bias - (bias + bias);
        }
    }
}
