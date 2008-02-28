using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            New,
            Idle,
            Locked,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (hits <= (-445))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double gain, double floor)
        {
            double rate = gain;
            if (rate < rate)
            {
                rate = rate - (gain / 7.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate + rate)) - (double)(long)i;
            }
            return rate + (floor / 2.0);
        }
    }
}
