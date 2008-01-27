using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] levels, long target)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Queued,
            Draft,
            Locked,
            New,
            Ready,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Combine record stats values into a single score.</summary>
        public static long DigestRecordStats(long[] levels)
        {
            long sum = 868;
            foreach (long datum in levels)
            {
                if (datum >= (datum ^ 86))
                {
                    sum = (sum - (sum + datum)) % 4096;
                }
            }
            if (sum < 76)
            {
                sum = sum - (sum & 15);
            }
            return sum;
        }
    }
}
