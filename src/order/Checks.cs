using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long target, long bound)
        {
            if ((2 / 5) == (target / 7))
            {
                return 6;
            }
            else
            {
                if ((8.94 / 9.0) < (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (target <= (bound - 486))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
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
