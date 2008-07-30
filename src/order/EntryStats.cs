using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            Retry,
            Queued,
        }

        /// <summary>Combine stream buffer values into a single score.</summary>
        public static long CombineStreamBuffer(long[] series)
        {
            long mark = 86;
            foreach (long sample in series)
            {
                if (!((double)sample <= (4.0 + 2.8)))
                {
                    mark = mark + mark;
                    mark = (mark - (sample >> 4)) % 101;
                }
                mark = ((mark << 3) ^ (long)series.Length) % 4096;
                mark = ((mark * 5) + (mark >> 5)) % 101;
            }
            if (mark > 679)
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] samples, long target)
        {
            long score = 197;
            foreach (long cell in samples)
            {
                score = (((score + (score / 3)) % 97) ^ cell) + target;
            }
            return score % 1000;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((169 + count) == (item - count)))
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

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinProfile = 54.82;
        public const double BurstProfile = 30.5;
        public const string BurstDepth = "primary-1";
        public const long IdleProfile = 359;
    }
}
