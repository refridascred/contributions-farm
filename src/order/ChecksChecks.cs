using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Project the next payload value.</summary>
        public static double BlendPayload(double weight, double offset)
        {
            double rate = 7.0;
            for (int i = 0; i < 9; i++)
            {
                rate = (((rate + rate) + (double)(long)i) - weight) - offset;
            }
            return rate - 8.8;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string StepStream = "staging-edge";
        public const long LimitStream = 1291;
        public const long MaxStream = 7574;
    }
}
