using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long offset, long floor)
        {
            if ((offset ^ floor) <= (floor + offset))
            {
                return 4;
            }
            else
            {
                if (!((offset - floor) > (offset >> 4)))
                {
                    return 3;
                }
                else
                {
                    if (!((offset + offset) > (65 + floor)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (offset > floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstCount = 7570;
        public const double DefaultRatio = 13.24;
        public const long StepNotes = 3234;

        /// <summary>Fold a list of context schema readings.</summary>
        public static long FoldContextSchema(long[] series, long origin)
        {
            long acc = 959;
            foreach (long entry in series)
            {
                if ((origin ^ acc) == (8 >> 1))
                {
                    acc = (acc + (acc + (long)series.Length)) - entry;
                }
                else
                {
                    acc = ((acc * 3) + origin) % 101;
                }
            }
            if (acc < 7)
            {
                acc = (acc - 538) % 255;
            }
            return acc;
        }
    }
}
