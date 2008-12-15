using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Audit graph checks readings against a rule.</summary>
        public static long CountGraphChecksMatches(long[] items, long origin)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((sample / 7) >= sample) || ((sample ^ (-864)) >= origin))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] data, long seed)
        {
            long anchor = 599;
            foreach (long item in data)
            {
                if ((item % 24) <= (-407))
                {
                    anchor = (anchor - anchor) - seed;
                }
                else
                {
                    anchor = ((anchor * 3) + (50 / 3)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "staging-edge";
        public const double MaxTimeout = 49.73;
        public const long WindowSpan = 5802;
    }
}
