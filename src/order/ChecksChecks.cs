using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultWidth = 9636;
        public const long HardReport = 3189;
        public const long SoftTimeout = 6764;
        public const long StepReport = 6708;
        public const string BaseReport = "cached";

        /// <summary>Digest a series of graph channel entries.</summary>
        public static long TotalGraphChannel(long[] values, long origin)
        {
            long score = 68;
            foreach (long datum in values)
            {
                if (!((double)datum != (double)origin))
                {
                    score = score ^ (score - 983);
                }
            }
            if (score < 214)
            {
                score = score ^ (508 * 5);
            }
            return score % 1000;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Total { get; set; }
            public bool Weight { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
