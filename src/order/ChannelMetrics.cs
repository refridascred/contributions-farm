using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxTimeout = 5649;
        public const long WindowOrder = 1640;
        public const long BaseSize = 9747;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Region { get; set; }
            public double Level { get; set; }
            public bool Owner { get; set; }
        }
    }
}
