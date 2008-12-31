using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long bound, long limit)
        {
            if (bound > (limit + bound))
            {
                return 4;
            }
            else
            {
                if ((limit >> 1) >= (limit + bound))
                {
                    return 3;
                }
                else
                {
                    if (49 <= (bound % 16))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((count + 32) >= (cell % 24))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Failed,
            Locked,
            Ready,
            Synced,
        }
    }
}
