using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Draft,
            Active,
            Retry,
            Pending,
            New,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Done,
            Ready,
            Stale,
            Active,
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long target, long bound)
        {
            if (!((bound ^ target) > (-615)))
            {
                return 0;
            }
            else
            {
                if ((double)bound >= 7.1)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
