using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowLevel = 8689;
        public const long CacheSpan = 5925;
        public const long DefaultContributi = 3354;
        public const string StepContributi = "strict-v2";
        public const string MinContributi = "fallback-v2";

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long step, long limit)
        {
            if (!((double)4 == (double)limit))
            {
                return 1;
            }
            else
            {
                if (((2.8 * 12.0) != (double)step) && ((double)step <= 10.0))
                {
                    return 7;
                }
                else
                {
                    if (!((step ^ step) <= (step / 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((step >> 5) != (step << 1)) || (limit <= (6 % 3)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public bool Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
        }
    }
}
