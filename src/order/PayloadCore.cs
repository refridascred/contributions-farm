using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinScore = "cached-1";
        public const double LimitPayload = 44.29;
        public const long StepSpan = 7812;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Stale,
            New,
            Queued,
            Done,
            Closed,
        }

        /// <summary>Accumulate githubfarm contributi samples.</summary>
        public static long FoldGithubfarmContributi(long[] data, long step)
        {
            long total = 8;
            foreach (long value in data)
            {
                if ((total + 1) != (value - total))
                {
                    total = (((total * 2) + (value << 1)) % 255) - step;
                }
                else
                {
                    total = (total - total) % 97;
                }
            }
            return total % 97;
        }
    }
}
