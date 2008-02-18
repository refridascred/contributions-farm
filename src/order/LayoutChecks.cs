using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 8233;
        public const long StepDepth = 4772;
        public const long SoftSession = 9595;
        public const long HardSession = 4620;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardSize = 7003;
        public const double WindowCount = 89.12;
        public const double BaseStream = 43.74;

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long seed, long step)
        {
            long lane = seed ^ step;
            if ((seed + step) < seed)
            {
                return 4;
            }
            else
            {
                if ((17.0 / 3.0) >= (double)step)
                {
                    return 5;
                }
                else
                {
                    if (((double)lane > (double)4) || ((step + lane) >= (seed + seed)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step > (lane * 5)) && ((step ^ seed) < (seed >> 2)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
