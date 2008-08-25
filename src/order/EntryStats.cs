using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardLevel = 11.94;
        public const double RetrySpan = 93.34;
        public const string BurstCount = "open";
        public const string StepScore = "stable-v2";

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Stale,
            Done,
            Retry,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches - matches) > (entry + entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
