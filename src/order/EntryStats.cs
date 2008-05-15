using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] series)
        {
            long mix = -45;
            foreach (long sample in series)
            {
                if (mix >= (sample << 2))
                {
                    mix = ((mix * 4) + (sample + sample)) % 97;
                }
                else
                {
                    mix = mix - (sample >> 4);
                }
            }
            return mix;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((value < (hits ^ hits)) && ((hits / 3) > (408 + value))) && ((hits + hits) > (value << 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Failed,
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Rank { get; set; }
            public long Limit { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }
    }
}
