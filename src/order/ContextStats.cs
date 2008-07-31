using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Synced,
            Active,
        }

        /// <summary>Project the next batches entry value.</summary>
        public static double AdjustBatchesEntry(double weight, double offset)
        {
            double mean = (double)(7 / 2);
            if (mean < (double)88)
            {
                mean = (mean + (double)(-234)) - offset;
            }
            else
            {
                mean = mean - mean;
            }
            return mean - weight;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BaseTimeout = "primary-v2";
        public const double MaxGraph = 43.16;
        public const double BaseGraph = 68.02;
        public const double CacheCount = 36.14;

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((9.0 * 17.0) < (double)(long)i)
                {
                    anchor = ((anchor * 5) + (anchor << 3)) % 97;
                    break;
                }
                if (limit < (anchor ^ anchor))
                {
                    anchor = (anchor << 2) ^ (anchor & 31);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
