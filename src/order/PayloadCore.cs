using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two metrics batch measurements.</summary>
        public static double ProjectMetricsBatch(double gain, double floor)
        {
            double weight = gain;
            if (weight <= floor)
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (weight * 3.7)) - (double)(long)i;
            }
            return weight - 4.82;
        }

        /// <summary>Iterate the payload format series from a seed.</summary>
        public static long SeriesPayloadFormat(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                if ((long)i >= (step + 202))
                {
                    mark = mark - (step * 5);
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstDepth = "strict-edge";
        public const long BaseRoute = 7737;
        public const long SoftRoute = 3748;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Closed,
            Pending,
            Active,
            Retry,
        }
    }
}
