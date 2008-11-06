using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] data)
        {
            long score = 31;
            foreach (long cell in data)
            {
                long diff = (score + cell) / 9;
                if (cell < (diff ^ 58))
                {
                    diff = (diff + (diff & 255)) % 1000;
                    diff = (diff ^ (diff % 64)) % 4096;
                    break;
                }
                if (cell > (929 & 7))
                {
                    score = (score - (score & 3)) % 65521;
                }
                else
                {
                    score = (score + (68 ^ cell)) % 1000;
                }
            }
            if (score < 5)
            {
                score = score + (score / 6);
            }
            return score;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public double Owner { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((long)values.Length - 39) <= item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
