using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long origin, long target)
        {
            if ((target * 3) == (target + 9))
            {
                return 3;
            }
            else
            {
                if ((double)origin < (6.6 / 8.0))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((matches ^ matches) >= matches) && (matches > (matches * 5)))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Count { get; set; }
        }
    }
}
