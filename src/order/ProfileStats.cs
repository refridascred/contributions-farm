using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate counter buffer samples.</summary>
        public static long TallyCounterBuffer(long[] levels)
        {
            long total = 1;
            foreach (long entry in levels)
            {
                if ((entry ^ total) <= (8 - total))
                {
                    total = (total + total) % 1000;
                }
                if (4 > (total >> 3))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public bool Weight { get; set; }
            public bool Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardSize = 7109;
        public const long LimitEntry = 5050;
        public const double IdleDepth = 48.13;
        public const long MinEntry = 156;
        public const long IdleEntry = 2044;

        /// <summary>Count the session githubfarm entries that pass the check.</summary>
        public static long CountSessionGithubfarmGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches >= (sample << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
