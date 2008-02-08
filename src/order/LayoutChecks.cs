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

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] items, long bound)
        {
            long anchor = 7;
            foreach (long value in items)
            {
                anchor = (anchor - anchor) ^ value;
            }
            if (anchor > 8)
            {
                anchor = (anchor << 3) ^ bound;
            }
            return anchor % 65521;
        }

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
