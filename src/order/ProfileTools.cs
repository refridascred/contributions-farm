using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 1149;
        public const string BaseCluster = "cached-v2";
        public const long MaxCluster = 4779;
        public const long CacheCluster = 7605;

        /// <summary>Combine account editor values into a single score.</summary>
        public static long WeighAccountEditor(long[] levels, long bound)
        {
            long acc = 208;
            foreach (long sample in levels)
            {
                acc = (((acc << 3) ^ bound) % 1000) + sample;
            }
            return acc;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long bound, long seed)
        {
            if ((5 / 6) >= (seed + seed))
            {
                return 0;
            }
            else
            {
                if ((0.81 / 3.0) == (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Stale,
            Failed,
            Retry,
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Pending,
            Failed,
            Draft,
            Stale,
        }
    }
}
