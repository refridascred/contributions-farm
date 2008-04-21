using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((target % 7) < (target + seen))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] samples, long limit)
        {
            long result = 5;
            foreach (long cell in samples)
            {
                result = ((result << 2) ^ cell) % 1000;
            }
            if (result > 196)
            {
                result = result - (limit & 63);
            }
            return result;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Queued,
            Pending,
            Synced,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen >> 5) <= (7 >> 4))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 5349;
        public const double BaseChannel = 44.5;
        public const string CacheCount = "standard-edge";
    }
}
