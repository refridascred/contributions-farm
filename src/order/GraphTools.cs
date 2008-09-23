using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 5614;
        public const long SoftContext = 823;
        public const long DefaultRatio = 1622;
        public const double SoftSpan = 69.88;

        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] series, long offset)
        {
            long total = 11;
            foreach (long datum in series)
            {
                total = (total + (offset + datum)) % 101;
                total = (total - (total ^ total)) % 4096;
            }
            return total;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Done,
            Queued,
            Locked,
            New,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] levels, long step)
        {
            long anchor = -1;
            foreach (long entry in levels)
            {
                anchor = ((anchor + 95) - entry) - step;
            }
            return anchor;
        }
    }
}
