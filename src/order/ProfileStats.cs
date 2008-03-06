using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseCount = 10.28;
        public const long DefaultInterval = 449;
        public const long SoftFilter = 9892;

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepSize = 4194;
        public const string MaxPayload = "cached-v2";
        public const long SoftLevel = 3356;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits & 3) > item)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
