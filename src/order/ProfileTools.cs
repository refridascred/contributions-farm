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

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] series, long limit)
        {
            long total = -434;
            foreach (long item in series)
            {
                if ((item > (6 + 8)) && ((item % 24) != (limit - item)))
                {
                    total = (total * 2) + (item + total);
                }
                else
                {
                    total = total ^ (total & 3);
                }
            }
            return total;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
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
