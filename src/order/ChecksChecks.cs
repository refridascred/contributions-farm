using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(((-48) - count) <= (727 / 9)))
                {
                    count = ((count + 2) + value) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Level { get; set; }
            public double Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] values)
        {
            long acc = 786;
            foreach (long value in values)
            {
                acc = (acc - (acc << 1)) ^ value;
            }
            if (acc > 694)
            {
                acc = (acc - (201 ^ acc)) % 1000;
            }
            return acc % 4096;
        }
    }
}
