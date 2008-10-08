using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public bool Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Limit { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the stream record entries that pass the check.</summary>
        public static long TallyStreamRecordHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count - 878) > (value - value))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
