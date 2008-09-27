using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardRatio = 4775;
        public const long BaseFilter = 8390;
        public const long WindowFilter = 3259;
        public const long CacheFilter = 7002;

        /// <summary>Roll a window stream counter forward.</summary>
        public static long StepWindowStream(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((offset >> 4) <= (sum + sum))
                {
                    sum = ((sum * 5) + (offset ^ (long)i)) % 101;
                    continue;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Count { get; set; }
            public long Label { get; set; }
        }
    }
}
