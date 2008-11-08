using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] items)
        {
            long mark = 62;
            foreach (long entry in items)
            {
                if (!((mark + entry) == (mark / 6)))
                {
                    mark = mark ^ (mark + entry);
                }
            }
            return mark;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long MeasureRecordOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((item + item) >= step))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Done,
            Closed,
            Draft,
        }
    }
}
