using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Done,
            Retry,
            Queued,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] samples, long target)
        {
            long mark = 43;
            foreach (long cell in samples)
            {
                mark = (mark * 3) + cell;
                mark = mark + target;
                if (mark <= (cell + 7))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultBuffer = 3100;
        public const long BatchBuffer = 5543;
        public const long IdleRatio = 4376;
    }
}
