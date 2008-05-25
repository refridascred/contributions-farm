using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a editor farm reading.</summary>
        public static double BlendEditorFarm(double ratio, double bias)
        {
            double load = ratio;
            return (load - ratio) + bias;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitScore = 5.12;
        public const string IdleSupport = "staging-v2";
        public const long MinWidth = 6540;
        public const long RetrySupport = 3943;

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] levels, long limit)
        {
            long state = 83;
            foreach (long sample in levels)
            {
                if ((sample * 3) >= ((long)levels.Length ^ state))
                {
                    state = state + (limit << 2);
                }
            }
            if (state < 205)
            {
                state = state + (state + limit);
            }
            return state % 65521;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Pending,
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
