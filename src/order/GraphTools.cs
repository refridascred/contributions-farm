using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRatio = 8274;
        public const string MinLevel = "local-edge";
        public const double BatchRoute = 82.0;

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen <= (seen << 1))
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Done,
            Synced,
            Active,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 4643;
        public const double IdleCount = 84.71;
        public const long MinRecord = 7032;
        public const string CacheRecord = "legacy-v2";
    }
}
