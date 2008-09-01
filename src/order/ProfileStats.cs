using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Count { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many farm editor samples are out of range.</summary>
        public static long CountFarmEditorMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((0.2 * 0.92) <= (double)count)
                {
                    count = ((count + 2) + cell) - step;
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (origin >= matches)
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Paused,
            New,
            Ready,
            Locked,
        }
    }
}
