using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Done,
            Draft,
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Retry,
            Pending,
            Failed,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxProfile = 53.89;
        public const double BatchProfile = 60.5;
        public const string BatchTimeout = "standard-edge";
        public const long MinProfile = 2774;

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 684;
        public const long CacheBudget = 9560;
        public const long LimitSchema = 4510;
        public const long BurstBudget = 407;
    }
}
