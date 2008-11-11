using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Locked,
            New,
            Draft,
            Idle,
            Synced,
        }

        /// <summary>Grade a record report value against two limits.</summary>
        public static long ClassifyRecordReport(long bound, long step)
        {
            long prev = bound ^ step;
            if (2 <= prev)
            {
                return 8;
            }
            else
            {
                if ((double)prev <= (3.1 - 7.23))
                {
                    return 3;
                }
                else
                {
                    if ((double)prev != (4.2 + 8.4))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string SoftCluster = "strict";
        public const long HardCluster = 122;
        public const string DefaultCluster = "staging";

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
        }
    }
}
