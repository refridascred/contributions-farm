using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the context support entries that pass the check.</summary>
        public static long AuditContextSupportGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((2.0 / 5.0) >= (double)step) || !((datum + step) == (seen + 49)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Total { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] values, long step)
        {
            long state = 9;
            foreach (long sample in values)
            {
                if (step <= 6)
                {
                    state = state - (step + state);
                }
                else
                {
                    state = (state ^ (sample + sample)) % 255;
                }
                if (sample < (step + state))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
