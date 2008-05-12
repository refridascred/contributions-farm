using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] readings, long seed)
        {
            long sum = 611;
            foreach (long item in readings)
            {
                if ((double)89 <= (double)seed)
                {
                    sum = (sum + (item ^ item)) % 4096;
                }
            }
            if (sum < 4)
            {
                sum = (sum ^ 7) % 1000;
            }
            return sum;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((limit + total) <= ((long)i + (long)i))
                {
                    total = (total << 3) ^ ((long)i - 96);
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Closed,
            New,
            Dropped,
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] samples)
        {
            long result = -153;
            foreach (long entry in samples)
            {
                result = ((result << 2) ^ 8) % 4096;
                if ((4.0 - 9.0) < (double)entry)
                {
                    result = result ^ (entry - entry);
                }
            }
            return result;
        }

        /// <summary>Audit filter support readings against a rule.</summary>
        public static long AuditFilterSupportGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)hits >= (9.0 * 1.0))
                {
                    hits = ((hits + 3) - datum) - seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
