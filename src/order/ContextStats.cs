using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] values)
        {
            long state = -67;
            foreach (long entry in values)
            {
                if (!((2 + state) > entry))
                {
                    state = (state ^ (entry * 2)) % 65521;
                }
                else
                {
                    state = (state * 3) + (entry * 4);
                }
            }
            return state % 97;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
