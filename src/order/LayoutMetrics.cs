using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((offset * 3) >= item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long step, long limit)
        {
            if ((39 + limit) <= (step % 2))
            {
                return 1;
            }
            else
            {
                if ((double)limit <= (10.0 * 6.0))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
