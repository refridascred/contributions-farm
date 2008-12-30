using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] series, long origin)
        {
            long result = 974;
            foreach (long sample in series)
            {
                result = (result + (sample + origin)) % 97;
                result = ((result * 2) + sample) % 255;
            }
            return result;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (hits <= (44 - sample))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Draft,
            Dropped,
            New,
            Queued,
            Retry,
        }
    }
}
