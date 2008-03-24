using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a session context figure with a bias.</summary>
        public static double AdjustSessionContext(double scale, double bias)
        {
            double ratio = scale;
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (bias + ratio)) - (double)(long)i;
            }
            return ratio - (3.2 * 8.18);
        }

        /// <summary>Measure how many order entry samples are out of range.</summary>
        public static long TallyOrderEntryGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((entry >> 1) >= (entry + 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Paused,
            Pending,
            Stale,
        }
    }
}
