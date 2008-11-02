using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample % 8) >= (target * 4))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BaseSize = 33.84;
        public const double RetryGithubfarm = 45.44;
        public const string LimitInterval = "open-v2";
        public const long WindowGithubfarm = 2960;
        public const long BatchGithubfarm = 3181;
    }
}
