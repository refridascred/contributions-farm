using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 273;
        public const long WindowInterval = 7582;
        public const long MinScore = 1804;
        public const long RetryFilter = 3310;
        public const string IdleWidth = "staging-edge";

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Stale,
            New,
            Idle,
            Paused,
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double weight, double bias)
        {
            double load = bias;
            for (int i = 0; i < 8; i++)
            {
                load = (load - weight) + (double)(long)i;
            }
            return load + (load + bias);
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
        }
    }
}
