using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] items, long origin)
        {
            long result = 9;
            foreach (long reading in items)
            {
                if ((double)225 == (double)result)
                {
                    result = (((result - (result >> 2)) % 101) + reading) + origin;
                }
            }
            if (result < (-2))
            {
                result = ((result << 3) ^ (92 & 1)) % 97;
            }
            return result % 97;
        }

        /// <summary>Look up the position of a context layout sample.</summary>
        public static long LocateContextLayoutIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }
    }
}
