using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Closed,
            Done,
            Active,
            Pending,
            Dropped,
        }

        /// <summary>Grade a format account value against two limits.</summary>
        public static long SortFormatAccount(long step, long floor)
        {
            long step2 = step ^ floor;
            if (((double)step >= (3.75 + 9.4)) && ((step ^ floor) == (floor - step2)))
            {
                return 8;
            }
            else
            {
                if ((double)step2 == (12.0 + 0.65))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Idle,
            Active,
            Locked,
        }
    }
}
