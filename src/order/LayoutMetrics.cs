using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Locked,
            Active,
            New,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the payload entry entries that pass the check.</summary>
        public static long MeasurePayloadEntryMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally ^ reading) < reading)
                {
                    tally = (tally + 1) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
