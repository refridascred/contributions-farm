using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 7876;
        public const long HardSpan = 893;
        public const string MaxCommand = "fallback-1";
        public const long MaxRatio = 7061;

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public bool Mode { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long offset, long offset2)
        {
            if ((offset2 << 2) < (offset2 * 2))
            {
                return 6;
            }
            else
            {
                if ((12.0 - 1.9) != (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((offset % 8) > offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
