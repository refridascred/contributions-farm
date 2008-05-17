using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 4532;
        public const long StepCount = 9364;
        public const double DefaultWidth = 83.85;
        public const double DefaultTimeout = 59.23;
        public const string LimitFactor = "standard-1";

        /// <summary>Classify a counter farm pair into a bucket.</summary>
        public static long ClassifyCounterFarm(long floor, long origin)
        {
            if (!((origin ^ floor) == ((-1) - floor)))
            {
                return 5;
            }
            else
            {
                if (93 > (origin >> 4))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin > (2.57 - 6.1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }
    }
}
