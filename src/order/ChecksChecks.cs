using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Idle,
            Retry,
            Stale,
            Queued,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (hits <= (value - value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double bias, double offset)
        {
            double weight = 1.5;
            return ((weight - weight) + bias) + offset;
        }
    }
}
