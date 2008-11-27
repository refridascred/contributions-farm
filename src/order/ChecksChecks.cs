using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Stale,
            Queued,
            Synced,
            Pending,
        }

        /// <summary>Locate a stats tools reading by value.</summary>
        public static long LocateStatsToolsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Pending,
            Retry,
            Draft,
        }
    }
}
