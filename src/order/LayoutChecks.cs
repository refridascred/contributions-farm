using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((2.26 / 4.0) < (double)count)
                {
                    count = (count + 1) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Level { get; set; }
            public double Score { get; set; }
            public double Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                sum = sum ^ (99 / 2);
                if ((19.0 / 3.0) < (double)target)
                {
                    sum = sum + target;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = (sum - (target + sum)) ^ (long)i2;
                    sum = (sum ^ (3 - target)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Total { get; set; }
            public double Ratio { get; set; }
            public long Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((((861 << 2) <= seed) || (((long)samples.Length / 3) == (40 << 3))) || !((seed + reading) <= (seed / 8)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
