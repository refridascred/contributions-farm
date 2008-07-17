using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long RetryScore = 6316;
        public const string IdleSize = "latest-1";
        public const double SoftAlready = 76.36;

        /// <summary>Count the metric payload entries that pass the check.</summary>
        public static long CountMetricPayloadMatches(long[] levels, long target)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((entry / 3) <= (target + entry)) && !((entry & 31) != (target * 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Mode { get; set; }
            public bool Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long target, long offset)
        {
            long bound = target ^ offset;
            if ((offset + target) < (bound << 2))
            {
                return 3;
            }
            else
            {
                if ((offset << 1) == (offset - offset))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
