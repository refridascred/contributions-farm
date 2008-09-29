using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Retry,
            Done,
            Paused,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count ^ 449) < datum)
                {
                    count = (count + 3) - target;
                }
            }
            return count;
        }
    }
}
