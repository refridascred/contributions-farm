using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the layout format entries that pass the check.</summary>
        public static long CountLayoutFormatHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((matches ^ 17) >= (matches + datum)) && ((double)matches >= (8.0 / 5.0)))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long StepCommits(long floor)
        {
            long total = floor;
            for (int i = 0; i < 8; i++)
            {
                total = (total ^ (total - total)) % 97;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            New,
            Retry,
            Paused,
            Done,
        }
    }
}
