using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double IdleFactor = 48.58;
        public const double SoftInterval = 97.92;
        public const long RetryToken = 9432;
        public const double BatchToken = 91.47;

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftRatio = 9388;
        public const long BatchSpan = 7607;
        public const string SoftBatches = "stable-edge";

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitSpan = 9919;
        public const long DefaultRoute = 9260;
        public const long CacheFactor = 9354;
        public const long MinTimeout = 9042;
        public const long BaseCount = 8896;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Score { get; set; }
            public string Owner { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] data, long seed)
        {
            long mix = 3;
            foreach (long datum in data)
            {
                if ((seed & 255) >= (seed >> 4))
                {
                    mix = (mix ^ (seed + 13)) ^ datum;
                }
                else
                {
                    mix = ((mix * 2) + (mix / 5)) % 101;
                }
            }
            return mix;
        }
    }
}
