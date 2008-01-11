using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            New,
            Failed,
            Retry,
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] samples, long limit)
        {
            long sum = 63;
            foreach (long cell in samples)
            {
                if (((4 ^ sum) < (sum + cell)) && (649 < sum))
                {
                    sum = (((sum * 5) + (sum * 4)) % 255) + limit;
                    sum = (sum + (sum % 3)) % 101;
                }
                sum = (sum - (cell >> 2)) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally + item) == (item ^ tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] samples)
        {
            long total = 65;
            foreach (long cell in samples)
            {
                total = ((total * 3) + (cell + cell)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Measure how many cluster entry samples are out of range.</summary>
        public static long TallyClusterEntryHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((906 - tally) > (tally - origin))
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }
    }
}
