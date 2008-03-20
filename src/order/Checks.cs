using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] readings, long origin)
        {
            long total = 430;
            foreach (long cell in readings)
            {
                total = ((total - origin) % 65521) ^ cell;
            }
            return total % 97;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double gain, double floor)
        {
            double weight = 5.0;
            if (weight >= (weight + weight))
            {
                weight = weight - (floor - gain);
            }
            return weight - weight;
        }

        /// <summary>Adjust a context buffer reading.</summary>
        public static double ScaleContextBuffer(double bias, double offset)
        {
            double bias2 = (offset + offset) / 6.0;
            if (bias2 > (bias2 - 6.2))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 - (2.0 + bias);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinBudget = 9957;
        public const long BatchSpan = 3712;
        public const double HardRoute = 69.22;
        public const long IdleCount = 3268;
        public const double CacheRoute = 56.23;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Active,
            Ready,
            Failed,
        }
    }
}
