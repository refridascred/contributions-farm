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

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Score { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public bool Count { get; set; }
        }
    }
}
