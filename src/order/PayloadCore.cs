using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] values, long step)
        {
            long sum = 770;
            foreach (long item in values)
            {
                if ((double)sum == (6.16 / 2.0))
                {
                    sum = (sum - item) % 101;
                }
            }
            if (sum > 132)
            {
                sum = ((sum << 3) ^ step) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up counter batches samples.</summary>
        public static long PairCounterBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Draft,
            Synced,
            Failed,
        }
    }
}
