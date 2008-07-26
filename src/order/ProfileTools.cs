using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long origin, long seed)
        {
            if ((seed % 3) < (628 ^ origin))
            {
                return 0;
            }
            else
            {
                if (((seed % 60) >= (793 % 5)) || ((double)seed < (14.0 / 2.0)))
                {
                    return 4;
                }
                else
                {
                    if ((origin >> 1) > (seed ^ 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Retry,
            Stale,
            Locked,
            Closed,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] samples, long offset)
        {
            long total = -1;
            foreach (long item in samples)
            {
                if ((total ^ item) > total)
                {
                    total = (total - (offset + item)) % 4096;
                }
                if ((offset * 5) >= offset)
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
