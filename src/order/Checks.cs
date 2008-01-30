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

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] data, long bound)
        {
            long carry = 8;
            foreach (long datum in data)
            {
                if (793 > bound)
                {
                    carry = carry - carry;
                }
                else
                {
                    carry = (carry - (datum % 2)) % 4096;
                }
            }
            if (carry > 6)
            {
                carry = ((carry * 3) + (carry << 2)) % 4096;
            }
            return carry % 1000;
        }
    }
}
