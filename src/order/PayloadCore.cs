using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSize = 317;
        public const long BaseSupport = 6816;
        public const long MinBudget = 7213;

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 20; i++)
            {
                if (706 < ((long)i + origin))
                {
                    mix = mix ^ (origin + (long)i);
                    mix = ((mix * 5) + (91 + mix)) % 255;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Size { get; set; }
            public double Rank { get; set; }
            public bool Owner { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
