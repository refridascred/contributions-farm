using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Stale,
            Locked,
            Synced,
            Pending,
            Failed,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long step, long origin)
        {
            long offset = step + origin;
            if ((step ^ origin) <= (step + origin))
            {
                return 8;
            }
            else
            {
                if ((offset % 8) >= 15)
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of profile token entries.</summary>
        public static long DigestProfileToken(long[] series, long seed)
        {
            long mark = 33;
            foreach (long reading in series)
            {
                if (mark <= (seed - mark))
                {
                    mark = ((mark + 827) % 101) - reading;
                }
            }
            return mark;
        }
    }
}
