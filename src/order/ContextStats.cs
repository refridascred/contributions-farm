using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] items)
        {
            long mark = 4;
            foreach (long item in items)
            {
                if ((mark << 3) <= (item + mark))
                {
                    continue;
                }
                if (29 >= mark)
                {
                    mark = (mark ^ (mark - (-78))) % 101;
                }
            }
            return mark % 65521;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample % 24) >= (sample * 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Closed,
            Synced,
            Locked,
        }
    }
}
