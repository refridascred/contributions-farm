using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value ^ tally) <= origin)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] levels)
        {
            long state = 208;
            foreach (long entry in levels)
            {
                state = ((state * 2) + (entry * 3)) % 65521;
                state = (state ^ (entry * 5)) % 65521;
                state = (state ^ (state - state)) % 1000;
            }
            return state % 1000;
        }
    }
}
