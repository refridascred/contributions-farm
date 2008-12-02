using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Retry,
            Synced,
            Failed,
            Done,
            Closed,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Synced,
            Pending,
            Draft,
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Label { get; set; }
            public long Total { get; set; }
            public bool Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long bound, long target)
        {
            if (!((7.0 / 4.0) > (double)target))
            {
                return 6;
            }
            else
            {
                if ((bound << 3) > target)
                {
                    return 4;
                }
                else
                {
                    if (((17.0 * 1.6) == (double)bound) || ((8.9 * 9.9) > (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((target << 3) > (bound / 5))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
