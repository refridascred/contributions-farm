using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double BlendBatch(double bias, double floor)
        {
            double drift = floor;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - drift) + (double)(long)i) + bias;
            }
            return drift - (floor - floor);
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Retry,
            Dropped,
            Failed,
            Idle,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
