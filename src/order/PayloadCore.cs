using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFactor = 9427;
        public const double IdleFarm = 83.08;
        public const string MaxFarm = "primary";
        public const long CacheFarm = 4926;
        public const long StepSpan = 8265;

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryLevel = 2530;
        public const long StepDepth = 5146;
        public const long BurstRatio = 3423;
    }
}
