using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 3897;
        public const double CacheScore = 31.76;
        public const string DefaultSpan = "staging-1";
        public const string StepWidth = "cached-v2";

        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BatchProfile = 25.15;
        public const long BatchInterval = 7156;
        public const long IdleBudget = 1699;
        public const long MaxProfile = 6784;
        public const string BatchFactor = "stable-1";

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Total { get; set; }
            public string Size { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Dropped,
            Draft,
            New,
        }
    }
}
