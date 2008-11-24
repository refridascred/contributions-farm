using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit channel schema readings against a rule.</summary>
        public static long CountChannelSchemaGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((507 << 2) < count)
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] readings)
        {
            long state = 74;
            foreach (long datum in readings)
            {
                if ((state / 4) > (datum + datum))
                {
                    continue;
                }
                if (!((double)state >= (4.09 * 2.12)))
                {
                    state = ((state * 5) + (long)readings.Length) % 4096;
                }
            }
            return state % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultRatio = 5881;
        public const double WindowCluster = 23.32;
        public const long BurstCluster = 8924;
        public const long StepCluster = 9510;
    }
}
