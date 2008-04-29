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

        /// <summary>Define profile limits and defaults.</summary>
        public const string SoftInterval = "open-edge";
        public const long HardBudget = 2667;
        public const long IdleProfile = 468;
        public const long StepDepth = 8469;
        public const long HardProfile = 1623;

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
