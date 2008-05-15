using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Done,
            Ready,
            Synced,
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((double)seed > (double)anchor)
                {
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            New,
            Failed,
            Synced,
            Queued,
        }
    }
}
