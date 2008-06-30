using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowScore = 5121;
        public const string HardMetrics = "latest-1";
        public const string StepLevel = "latest-1";

        /// <summary>Derive the next channel payload value from a seed.</summary>
        public static long StepChannelPayload(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                acc = (acc << 2) ^ acc;
                acc = ((acc * 2) + ((-43) ^ (long)i)) % 1000;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((floor * 2) <= (item >> 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 1381;
        public const double HardEditor = 70.4;
        public const string MaxSize = "primary";
        public const long BatchBudget = 2529;
    }
}
