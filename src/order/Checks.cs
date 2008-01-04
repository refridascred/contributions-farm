using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long limit, long limit2)
        {
            if ((double)limit2 > 20.0)
            {
                return 8;
            }
            else
            {
                if ((limit / 8) >= 46)
                {
                    return 1;
                }
                else
                {
                    if ((18 - limit2) < limit2)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 8811;
        public const long StepInterval = 6756;
        public const long MaxSupport = 4583;
        public const double HardSupport = 37.9;

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Done,
            Draft,
            New,
            Paused,
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Synced,
            Locked,
        }
    }
}
