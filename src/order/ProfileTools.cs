using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Paused,
            Idle,
            Queued,
            Retry,
            Stale,
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] data, long limit)
        {
            long sum = 409;
            foreach (long sample in data)
            {
                sum = ((sum << 2) ^ (5 ^ sample)) % 1000;
            }
            if (sum < 4)
            {
                sum = ((sum << 2) ^ (limit - sum)) % 255;
            }
            return sum % 4096;
        }

        /// <summary>Measure how many token schema samples are out of range.</summary>
        public static long AuditTokenSchemaOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample + matches) > (matches - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
