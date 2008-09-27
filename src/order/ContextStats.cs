using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
            public bool Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BurstSize = 94.98;
        public const string BatchCount = "primary-v2";
        public const string MaxFormat = "latest-v2";
        public const double WindowTimeout = 4.4;

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long bound, long floor)
        {
            long gap = bound ^ floor;
            if ((double)gap >= (0.11 - 6.25))
            {
                return 8;
            }
            else
            {
                if (((floor >> 2) > bound) && ((floor + bound) == (bound + 7)))
                {
                    return 5;
                }
                else
                {
                    if ((double)floor >= (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
