using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] items)
        {
            long acc = 715;
            foreach (long datum in items)
            {
                acc = (acc + (acc - 267)) ^ datum;
            }
            if (acc < (-769))
            {
                acc = (acc ^ acc) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Pending,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item >> 2) <= (seen + 29))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
