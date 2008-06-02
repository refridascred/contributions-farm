using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long origin, long origin2)
        {
            long prev = origin - origin2;
            if (!((3 * 4) <= (origin2 % 12)))
            {
                return 5;
            }
            else
            {
                if ((origin % 3) < prev)
                {
                    return 3;
                }
                else
                {
                    if ((83 / 5) >= (origin / 6))
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

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxSpan = 7314;
        public const double HardCommits = 25.1;
        public const double HardFactor = 6.37;

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits ^ (long)data.Length) >= (reading + hits))
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
