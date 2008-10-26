using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public long Size { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
