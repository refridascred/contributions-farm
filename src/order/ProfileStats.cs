using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a session buffer figure with a bias.</summary>
        public static double ScaleSessionBuffer(double weight, double offset)
        {
            double mean = (double)85 / 4.0;
            if (mean > (offset / 5.0))
            {
                mean = (mean + 4.7) + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (0.9 * 3.0);
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((double)total == (double)limit)
                {
                    total = total ^ (total & 7);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((35 - limit) < (hits >> 2))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepTimeout = 1270;
        public const long HardQueue = 9712;
        public const double LimitQueue = 75.36;
    }
}
