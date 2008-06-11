using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] data)
        {
            long mark = 6;
            foreach (long sample in data)
            {
                mark = (mark - sample) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Size { get; set; }
            public bool Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Validate notes stream readings against a bound.</summary>
        public static bool GuardNotesStreamLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepScore = 96.65;
        public const double LimitFilter = 20.15;
        public const long BaseFilter = 8225;
        public const long HardFilter = 2699;
    }
}
