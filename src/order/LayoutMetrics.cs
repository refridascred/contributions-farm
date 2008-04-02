using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Rank { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many githubfarm record samples are out of range.</summary>
        public static long CountGithubfarmRecordMatches(long[] values, long origin)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((4.0 / 3.0) <= (double)item)
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long bound, long floor)
        {
            if (bound < (bound << 3))
            {
                return 6;
            }
            else
            {
                if ((double)bound <= (16.0 * 10.0))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
