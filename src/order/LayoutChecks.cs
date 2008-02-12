using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 3251;
        public const double MinInterval = 24.46;
        public const long CacheGithubfarm = 4653;

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Count the layout editor entries that pass the check.</summary>
        public static long TallyLayoutEditorHits(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((origin + 24) <= cell)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            Done,
            Draft,
        }
    }
}
