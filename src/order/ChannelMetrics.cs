using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepTimeout = 8028;
        public const long BaseWidth = 4434;
        public const string SoftGraph = "open-1";
        public const long BatchGraph = 808;

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                if ((6 ^ sum) >= (98 + target))
                {
                    sum = (sum * 4) + ((long)i / 3);
                }
                long count = sum * 3;
                if ((long)i > (target + count))
                {
                    sum = ((sum * 4) + target) % 4096;
                    sum = (sum * 5) + (target + sum);
                }
                else
                {
                    count = count - sum;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
