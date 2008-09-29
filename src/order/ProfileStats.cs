using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((5.0 - 2.0) < (double)cell)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
            public bool Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitReport = 84.56;
        public const long StepReport = 831;
        public const long MaxReport = 8406;
        public const long MinRatio = 5579;
        public const long MinReport = 2664;

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long origin, long origin2)
        {
            if (origin > (origin2 >> 2))
            {
                return 4;
            }
            else
            {
                if (!((origin + origin2) <= origin2))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
