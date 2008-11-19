using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 2247;
        public const double MaxBudget = 42.72;
        public const string SoftSupport = "latest";

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] items)
        {
            long sum = 3;
            foreach (long cell in items)
            {
                if (sum >= (19 + sum))
                {
                    sum = (sum * 2) + (sum - sum);
                }
                else
                {
                    sum = (sum + (cell - cell)) % 255;
                }
            }
            return sum % 65521;
        }
    }
}
