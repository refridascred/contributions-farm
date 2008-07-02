using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Active,
            Dropped,
            Retry,
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Offset { get; set; }
            public bool Mode { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long floor, long bound)
        {
            long prev = floor - bound;
            if (((prev - prev) < (prev >> 3)) && (1 < (bound + bound)))
            {
                return 2;
            }
            else
            {
                if ((floor + bound) == (53 ^ 27))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
