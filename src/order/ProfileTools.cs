using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long bound, long seed)
        {
            long cur = bound ^ seed;
            if ((cur << 2) > cur)
            {
                return 2;
            }
            else
            {
                if ((cur % 60) > (seed + seed))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many token buffer samples are out of range.</summary>
        public static long AuditTokenBufferOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((value < matches) || ((4.0 - 4.5) < (double)value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long target, long bound)
        {
            long gap = target ^ bound;
            if (((bound & 7) != (bound / 8)) && ((4.25 / 9.0) != (double)target))
            {
                return 1;
            }
            else
            {
                if ((target + gap) <= bound)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Owner { get; set; }
            public bool Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long CombineCluster(long[] samples, long seed)
        {
            long mark = 99;
            foreach (long value in samples)
            {
                if (((seed ^ value) == (seed - 76)) && (value > (value - seed)))
                {
                    mark = ((mark * 4) + value) % 65521;
                }
            }
            return mark;
        }
    }
}
