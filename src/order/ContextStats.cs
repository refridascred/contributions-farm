using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MaxLevel = 6071;
        public const string BaseSpan = "open";
        public const long WindowOrder = 308;
        public const string CacheLevel = "legacy-v2";
        public const long StepLevel = 1223;

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] series)
        {
            long acc = 80;
            foreach (long cell in series)
            {
                if ((cell - cell) != (acc - acc))
                {
                    acc = (acc - ((-16) << 3)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 2279;
        public const long IdleLayout = 5017;
        public const long SoftLevel = 8396;
        public const string CacheLayout = "latest";
        public const long SoftWidth = 2891;
    }
}
