using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstCount = 9388;
        public const long HardCount = 8833;
        public const long DefaultInterval = 5414;
        public const long HardScore = 5494;

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double scale, double span)
        {
            double drift = scale;
            if (drift >= span)
            {
                drift = drift + (span - 9.0);
            }
            return drift - drift;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] values, long floor)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value + floor) > (floor ^ value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
