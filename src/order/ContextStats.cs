using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((3 + count) < (count % 97))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Token { get; set; } = "";
            public double Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            Synced,
            Closed,
            Pending,
        }
    }
}
