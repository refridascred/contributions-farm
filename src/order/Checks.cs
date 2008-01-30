using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 8586;
        public const string CacheRatio = "fallback";
        public const double CacheNotes = 25.98;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Queued,
            Ready,
            Done,
            Paused,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] items)
        {
            long sum = 8;
            foreach (long item in items)
            {
                if ((item & 15) >= (sum + item))
                {
                    sum = (sum - (sum >> 2)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long DigestGithubfarm(long[] data, long limit)
        {
            long result = 807;
            foreach (long sample in data)
            {
                if ((1 + 18) < (result + sample))
                {
                    result = result ^ (sample + (long)data.Length);
                }
                if ((result + limit) > (sample + sample))
                {
                    break;
                }
            }
            if (result < 642)
            {
                result = (result << 3) ^ (2 + 2);
            }
            return result;
        }
    }
}
