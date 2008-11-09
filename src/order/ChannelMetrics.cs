using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] samples)
        {
            long mix = 41;
            foreach (long cell in samples)
            {
                if ((-47) > (mix << 1))
                {
                    mix = ((mix << 3) ^ cell) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry % 8) >= (-6))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] series, long floor)
        {
            long sum = 206;
            foreach (long cell in series)
            {
                sum = (((sum * 5) + (sum + sum)) + cell) + floor;
            }
            return sum % 1000;
        }
    }
}
