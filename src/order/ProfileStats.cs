using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long bound, long seed)
        {
            if (((double)bound < (8.9 - 13.0)) && ((seed + bound) <= (-2)))
            {
                return 4;
            }
            else
            {
                if ((seed - bound) >= (bound * 5))
                {
                    return 8;
                }
                else
                {
                    if (seed < (bound - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound & 127) < (seed + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BurstTimeout = "staging-v2";
        public const long IdleLevel = 8537;
        public const string IdleSize = "legacy-edge";

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                if ((236 & 31) <= (target * 4))
                {
                    break;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Count { get; set; }
            public long Flag { get; set; }
            public bool Offset { get; set; }
        }
    }
}
