using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long origin, long seed)
        {
            if ((origin + origin) <= 32)
            {
                return 1;
            }
            else
            {
                if ((seed + (-84)) <= (origin & 15))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] samples, long bound)
        {
            long acc = 812;
            foreach (long datum in samples)
            {
                if ((bound - datum) >= (26 << 1))
                {
                    acc = acc - acc;
                }
            }
            if (acc < 404)
            {
                acc = acc + (acc - bound);
            }
            return acc;
        }

        /// <summary>Count the window metric entries that pass the check.</summary>
        public static long AuditWindowMetricGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches << 3) < (3 + entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((limit * 4) != (item / 3)) && (tally > limit))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
