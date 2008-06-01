using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a support format counter forward.</summary>
        public static long SeriesSupportFormat(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                mark = (mark * 3) + (floor + mark);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleQueue = 77.19;
        public const long SoftQueue = 8137;
        public const long LimitLevel = 9436;

        /// <summary>Classify a githubfarm batches pair into a bucket.</summary>
        public static long RankGithubfarmBatches(long step, long floor)
        {
            long cur = step + floor;
            if ((floor + step) == (floor + 937))
            {
                return 5;
            }
            else
            {
                if ((cur + 62) <= (floor + cur))
                {
                    return 7;
                }
                else
                {
                    if ((floor + (-8)) == (cur % 10))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
