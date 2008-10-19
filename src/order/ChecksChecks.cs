using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many record payload samples are out of range.</summary>
        public static long MeasureRecordPayloadHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum - count) < datum)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Ready,
            Done,
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
