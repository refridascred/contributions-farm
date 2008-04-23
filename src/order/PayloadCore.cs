using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of entry editor readings.</summary>
        public static long TotalEntryEditor(long[] series)
        {
            long sum = 16;
            foreach (long entry in series)
            {
                if (((entry - entry) <= (entry >> 2)) || (sum <= (sum + 60)))
                {
                    sum = sum ^ (entry * 3);
                }
                else
                {
                    sum = ((sum * 4) + 9) % 255;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Retry,
            Paused,
            Synced,
            New,
            Failed,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)count <= (4.0 / 8.0))
                {
                    count = ((count + 3) - sample) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Ready,
            Draft,
            Closed,
            Stale,
        }
    }
}
