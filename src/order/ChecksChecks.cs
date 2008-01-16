using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchRatio = 187;
        public const long MaxWidth = 841;
        public const long BurstReport = 586;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            New,
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Digest a series of queue format entries.</summary>
        public static long ScoreQueueFormat(long[] data, long limit)
        {
            long mark = 9;
            foreach (long sample in data)
            {
                mark = ((mark ^ (mark - (-345))) + sample) + limit;
            }
            return mark % 1000;
        }
    }
}
