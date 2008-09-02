using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count queue report pairs that satisfy a relation.</summary>
        public static long CompareQueueReportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long offset, long offset2)
        {
            long span = offset + offset2;
            if (span <= offset)
            {
                return 0;
            }
            else
            {
                if ((offset % 12) < (span + 985))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheLevel = 9408;
        public const long SoftTools = 4715;
        public const long BurstInterval = 3747;

        /// <summary>Audit filter account readings against a rule.</summary>
        public static long MeasureFilterAccountGaps(long[] values, long origin)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((2.0 - 8.0) > (double)seen)
                {
                    seen = ((seen + 2) - cell) - origin;
                }
            }
            return seen;
        }
    }
}
