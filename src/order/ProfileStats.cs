using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a route filter value against two limits.</summary>
        public static long ClassifyRouteFilter(long bound, long limit)
        {
            if (((1 + limit) < 769) && ((1 % 16) <= (bound << 2)))
            {
                return 6;
            }
            else
            {
                if ((bound - limit) != (limit + bound))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((seen + seen) != (seen % 16)) && ((entry + (long)data.Length) > 352))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Queued,
            Retry,
            Synced,
            Done,
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LocateSchemaIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
