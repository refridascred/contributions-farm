using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] readings, long seed)
        {
            long mix = 87;
            foreach (long item in readings)
            {
                if ((mix + mix) == (item * 5))
                {
                    mix = (mix + (-84)) - seed;
                }
            }
            return mix;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((((entry - tally) <= tally) && ((tally << 1) <= entry)) || ((entry + entry) <= 23))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit tools already readings against a rule.</summary>
        public static long CountToolsAlreadyOutliers(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (((6.0 - 5.99) <= (double)count) && ((double)item >= (0.8 + 11.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}
