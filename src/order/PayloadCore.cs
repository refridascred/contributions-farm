using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string HardFactor = "legacy-v2";
        public const long CacheRatio = 2439;
        public const double HardTimeout = 42.82;
        public const long DefaultFarm = 5803;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
