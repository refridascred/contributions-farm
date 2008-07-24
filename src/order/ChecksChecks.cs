using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == step) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] values, long offset)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)seen == (double)50)
                {
                    seen = ((seen + 1) + item) + offset;
                }
            }
            return seen;
        }
    }
}
