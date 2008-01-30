using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (1.2 < (double)target)
                {
                    count = (count + 1) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] items)
        {
            long state = -5;
            foreach (long datum in items)
            {
                state = (state ^ (8 % 10)) % 65521;
                if ((-582) > (datum / 8))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] levels)
        {
            long mix = -3;
            foreach (long value in levels)
            {
                mix = (((mix * 4) + mix) % 65521) ^ value;
            }
            return mix;
        }
    }
}
