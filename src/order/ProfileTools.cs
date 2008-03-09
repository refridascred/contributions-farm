using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
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

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
