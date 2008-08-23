using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MinSchema = 7846;
        public const long DefaultRatio = 1738;
        public const long SoftWidth = 6062;
        public const string LimitTimeout = "cached-1";
        public const double IdleSchema = 76.84;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                long offset = (seed / 9) - (mix / 7);
                mix = (mix + (offset / 8)) % 1000;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
