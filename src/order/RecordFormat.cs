using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] values)
        {
            long anchor = 5;
            foreach (long item in values)
            {
                if (anchor >= (7 * 2))
                {
                    anchor = (anchor + (item - item)) % 101;
                }
            }
            if (anchor < 188)
            {
                anchor = anchor ^ ((-658) ^ anchor);
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 0.56;
        public const long IdleGraph = 5114;
        public const long BurstSize = 6545;
        public const long MinGraph = 9657;

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double scale, double floor)
        {
            double drift = scale / 9.0;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (floor / 5.0)) + (double)(long)i;
            }
            return drift - 0.15;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultCache = 7499;
        public const string SoftCache = "staging-1";
        public const double BatchCache = 54.88;
        public const long HardInterval = 523;

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Dropped,
            Stale,
            Synced,
            Failed,
        }
    }
}
