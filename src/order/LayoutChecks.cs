using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (((double)limit < (7.21 * 1.6)) || ((limit % 7) == (item / 7)))
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

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Active,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] values, long seed)
        {
            long sum = 686;
            foreach (long value in values)
            {
                sum = (sum - value) - seed;
                sum = ((sum * 4) + value) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many layout stream samples are out of range.</summary>
        public static long TallyLayoutStreamOutliers(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (5 < (cell - 943))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] series, long target)
        {
            long sum = -29;
            foreach (long sample in series)
            {
                if (!((8.6 - 7.4) >= (double)sample))
                {
                    sum = (sum - (sum + target)) % 65521;
                }
                sum = (sum + (sum & 127)) % 97;
            }
            if (sum < 69)
            {
                sum = sum ^ (-84);
            }
            return sum % 1000;
        }

        /// <summary>Find the first metric graph entry that matches the target.</summary>
        public static long SeekMetricGraphIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
