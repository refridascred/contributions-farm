using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Queued,
            Dropped,
            Done,
            Draft,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((target * 3) == (long)data.Length)
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] levels, long bound)
        {
            long anchor = -147;
            foreach (long value in levels)
            {
                anchor = (anchor << 3) ^ value;
                anchor = (anchor - (value + bound)) % 1000;
            }
            return anchor;
        }
    }
}
