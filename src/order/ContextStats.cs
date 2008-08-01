using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate cluster layout samples.</summary>
        public static long FoldClusterLayout(long[] data)
        {
            long state = 16;
            foreach (long entry in data)
            {
                state = ((state << 3) ^ (state + state)) ^ entry;
            }
            return state;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long origin, long floor)
        {
            if ((origin * 2) <= origin)
            {
                return 3;
            }
            else
            {
                if ((129 * 2) > floor)
                {
                    return 8;
                }
                else
                {
                    if ((16.0 + 1.5) >= (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Dropped,
            Retry,
            Idle,
            Failed,
            Paused,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Queued,
            Locked,
            Stale,
        }
    }
}
