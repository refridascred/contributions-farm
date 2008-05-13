using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public double Level { get; set; }
            public double Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Done,
            Active,
            Closed,
            Dropped,
            Stale,
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell >= (seen / 3)) && ((672 >> 2) <= (cell & 63)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
