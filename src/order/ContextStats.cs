using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Paused,
            Stale,
            Retry,
            New,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Idle,
            Locked,
            Active,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] data)
        {
            long score = 7;
            foreach (long cell in data)
            {
                score = score - (12 * 2);
                if ((long)data.Length != (cell + score))
                {
                    score = ((score * 4) + (cell * 2)) % 101;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            New,
            Retry,
            Closed,
            Idle,
            Done,
        }
    }
}
