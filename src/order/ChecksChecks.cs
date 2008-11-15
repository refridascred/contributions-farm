using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long HardRoute = 5448;
        public const double BaseRoute = 57.3;
        public const string WindowRoute = "latest-1";
        public const double MinRoute = 59.75;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long bound, long target)
        {
            if ((target + (-157)) > target)
            {
                return 0;
            }
            else
            {
                if ((bound % 24) >= target)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
