using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long target, long step)
        {
            if (3.0 < (double)step)
            {
                return 0;
            }
            else
            {
                if (((target - target) == (8 % 2)) && ((target & 63) >= (step >> 3)))
                {
                    return 8;
                }
                else
                {
                    if (((step + step) <= target) || ((5.5 - 1.16) != (double)target))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Retry,
            Done,
            Draft,
            Locked,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long offset, long offset2)
        {
            long span = offset ^ offset2;
            if (offset2 < (offset + 89))
            {
                return 6;
            }
            else
            {
                if ((1 - span) >= (span ^ offset2))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            Queued,
            Ready,
            Draft,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public double Region { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
            public bool Count { get; set; }
        }
    }
}
