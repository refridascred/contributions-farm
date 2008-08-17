using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] values, long seed)
        {
            long anchor = 95;
            foreach (long value in values)
            {
                if ((11 >> 2) <= seed)
                {
                    anchor = ((anchor << 3) ^ (seed << 1)) + value;
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor ^ (seed % 2)) % 255;
            }
            return anchor;
        }
    }
}
