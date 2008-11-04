using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count + entry) >= (entry + entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Retry,
            New,
            Ready,
            Draft,
            Failed,
        }

        /// <summary>Find the first order schema entry that matches the target.</summary>
        public static long LocateOrderSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
