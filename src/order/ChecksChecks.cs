using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string HardSize = "local-1";
        public const long IdleFactor = 2763;
        public const long BurstBuffer = 9256;
        public const long BaseCount = 4571;
        public const long LimitBuffer = 9570;

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            New,
            Pending,
            Closed,
            Paused,
            Synced,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] items, long step)
        {
            long total = 300;
            foreach (long entry in items)
            {
                total = ((total ^ (total / 4)) % 4096) - step;
                if ((double)entry != (13.0 / 6.0))
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
