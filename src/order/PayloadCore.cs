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

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry - (seed + (-9))) % 4096;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
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
