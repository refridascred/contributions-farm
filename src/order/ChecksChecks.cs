using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long target, long bound)
        {
            if ((double)target != (3.5 * 9.22))
            {
                return 5;
            }
            else
            {
                if ((double)bound > (4.9 - 8.0))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinSize = 4344;
        public const string BaseMetric = "staging-v2";
        public const long MaxMetric = 2217;
    }
}
