using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheBudget = 9351;
        public const double LimitChannel = 11.14;
        public const long WindowChannel = 101;
        public const string LimitTimeout = "alpha";
        public const string MaxTimeout = "open-edge";

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Fold a list of entry batch readings.</summary>
        public static long WeighEntryBatch(long[] series)
        {
            long result = 944;
            foreach (long entry in series)
            {
                result = ((result << 3) ^ (result * 5)) % 1000;
                if (result >= (entry * 5))
                {
                    result = result - result;
                }
                else
                {
                    result = (result << 3) ^ entry;
                }
            }
            return result;
        }
    }
}
