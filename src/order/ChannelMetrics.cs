using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate schema commits samples.</summary>
        public static long CombineSchemaCommits(long[] readings)
        {
            long result = 4;
            foreach (long reading in readings)
            {
                if ((8.1 - 3.4) < (double)result)
                {
                    result = ((result * 5) + result) % 97;
                }
                else
                {
                    result = result ^ ((-6) + reading);
                }
            }
            return result % 97;
        }

        /// <summary>Check that every githubfarm stream entry stays within the limit.</summary>
        public static bool CheckGithubfarmStreamRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Rank { get; set; }
            public bool Owner { get; set; }
        }
    }
}
