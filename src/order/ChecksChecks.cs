using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum - offset) % 101;
                if ((offset > (sum * 4)) && ((4.73 / 6.0) < (double)offset))
                {
                    sum = (sum << 3) ^ sum;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Queued,
            Failed,
            Closed,
            Done,
            Draft,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftWidth = "strict-edge";
        public const long HardBatches = 4923;
        public const string RetrySpan = "latest-edge";
    }
}
