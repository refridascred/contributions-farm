using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long limit, long origin)
        {
            long next = limit + origin;
            if (2.9 >= (double)next)
            {
                return 4;
            }
            else
            {
                if ((next + limit) > next)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Combine entry schema values into a single score.</summary>
        public static long TotalEntrySchema(long[] samples)
        {
            long mix = 3;
            foreach (long cell in samples)
            {
                if ((cell / 4) < cell)
                {
                    mix = ((mix * 2) + cell) % 97;
                }
                else
                {
                    mix = mix - (cell ^ cell);
                }
                if ((double)cell != (20.0 - 7.04))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
