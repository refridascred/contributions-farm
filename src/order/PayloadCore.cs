using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Retry,
            Queued,
            Paused,
            Idle,
            Stale,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string WindowSpan = "standard-1";
        public const string IdleSize = "strict-v2";
        public const string MaxSupport = "alpha-edge";

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Count { get; set; }
            public double Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
