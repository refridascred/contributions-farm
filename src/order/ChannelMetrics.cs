using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public long Limit { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleCount = 66.52;
        public const double StepSchema = 86.28;
        public const long HardTimeout = 966;
    }
}
