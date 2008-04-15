using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((floor - mix) < (floor / 9))
                {
                    mix = (mix << 2) ^ mix;
                }
                mix = (mix * 2) + (mix + mix);
                if (!(mix >= (floor / 4)))
                {
                    mix = mix + (floor * 3);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((5.0 * 12.0) != (double)entry) && ((entry >> 2) == (seen + entry)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
        }
    }
}
