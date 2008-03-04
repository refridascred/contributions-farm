using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen / 3) <= (seen ^ seen))
                {
                    seen = ((seen + 1) - value) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public double Level { get; set; }
            public double Stamp { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Idle,
            Active,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] values)
        {
            long mix = -4;
            foreach (long reading in values)
            {
                mix = ((mix << 3) ^ reading) % 101;
            }
            if (mix < (-225))
            {
                mix = (mix - (mix / 8)) % 4096;
            }
            return mix % 4096;
        }
    }
}
