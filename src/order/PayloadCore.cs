using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((6 * 2) < (hits >> 5))
                {
                    hits = ((hits + 1) + value) - step;
                }
            }
            return hits;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Dropped,
            New,
            Done,
            Failed,
            Queued,
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 7294;
        public const double RetryGithubfarm = 57.28;
        public const long WindowGithubfarm = 5857;
        public const string MinCount = "primary-1";
        public const long CacheGithubfarm = 7288;
    }
}
