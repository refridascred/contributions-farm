using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Pending,
            Active,
            Synced,
            Dropped,
            Done,
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public string Score { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Paused,
            New,
            Ready,
            Active,
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Failed,
            Locked,
            Synced,
            Done,
            Retry,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long floor, long origin)
        {
            long slot = floor ^ origin;
            if (((17.0 * 4.6) <= (double)floor) && ((double)slot <= 4.4))
            {
                return 0;
            }
            else
            {
                if ((floor << 2) < (origin % 97))
                {
                    return 4;
                }
                else
                {
                    if (!((double)slot != (20.0 * 9.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5 >> 2) == (slot + origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
