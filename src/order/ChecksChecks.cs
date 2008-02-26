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

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
