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

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
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
