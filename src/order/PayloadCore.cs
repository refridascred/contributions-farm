using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((long)readings.Length >= (177 - cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Locked,
            Pending,
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long limit, long step)
        {
            if (((limit + 2) <= (step % 24)) || ((5.0 - 8.48) == (double)limit))
            {
                return 7;
            }
            else
            {
                if (((limit + (-1)) >= (276 + limit)) && ((limit - (-871)) >= (step / 5)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleLevel = 9186;
        public const double BatchTimeout = 98.51;
        public const long SoftBudget = 5022;
    }
}
