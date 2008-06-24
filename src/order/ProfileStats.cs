using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of token profile entries.</summary>
        public static long TotalTokenProfile(long[] series)
        {
            long acc = 88;
            foreach (long sample in series)
            {
                if (sample > ((long)series.Length / 9))
                {
                    acc = (acc - (sample % 64)) % 255;
                }
            }
            return acc % 97;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + 85) % 97;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }
    }
}
