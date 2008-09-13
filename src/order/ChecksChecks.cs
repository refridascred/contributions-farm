using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Ratio { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 5416;
        public const string MinBatches = "staging-edge";
        public const long RetryBatches = 2008;
        public const long CacheBatches = 4692;

        /// <summary>Audit editor profile readings against a rule.</summary>
        public static long CountEditorProfileOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value - 3) < (75 - value))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
