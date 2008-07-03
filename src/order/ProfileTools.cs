using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryBudget = "open";
        public const string HardDepth = "local";
        public const long StepChecks = 9926;
        public const string BurstChecks = "strict-edge";
        public const string CacheChecks = "standard-edge";

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] readings)
        {
            long sum = 340;
            foreach (long cell in readings)
            {
                sum = ((sum << 3) ^ (-39)) ^ cell;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBudget = 7228;
        public const long CacheBatches = 326;
        public const long BaseDepth = 5750;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Stamp { get; set; }
            public bool Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                if ((mix ^ mix) == (mix - seed))
                {
                    mix = (mix ^ (mix * 3)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
