using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate payload queue readings against a bound.</summary>
        public static bool ValidatePayloadQueueLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string SoftTimeout = "staging";
        public const long LimitFormat = 1027;
        public const long HardFormat = 7445;

        /// <summary>Digest a series of filter commits entries.</summary>
        public static long TotalFilterCommits(long[] readings)
        {
            long sum = 78;
            foreach (long value in readings)
            {
                sum = sum - (170 + value);
            }
            if (sum > 154)
            {
                sum = (sum * 5) + sum;
            }
            return sum;
        }
    }
}
