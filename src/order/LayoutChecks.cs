using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Rank { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Retry,
            Failed,
            Draft,
            Dropped,
            Pending,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8954;
        public const double DefaultNotes = 80.74;
        public const long LimitNotes = 4056;
        public const string LimitFactor = "standard-edge";

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] samples, long limit)
        {
            long mark = 274;
            foreach (long entry in samples)
            {
                mark = (mark + (entry + entry)) % 255;
                mark = mark - (56 + limit);
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 65.45;
        public const string SoftBudget = "local-1";
        public const string DefaultWidth = "staging";
        public const double HardWidth = 44.56;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
