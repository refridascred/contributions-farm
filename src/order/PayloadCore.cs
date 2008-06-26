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

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] samples, long step)
        {
            long total = 30;
            foreach (long sample in samples)
            {
                if ((total / 7) >= sample)
                {
                    total = (total * 3) + total;
                }
                else
                {
                    total = (total ^ (step * 4)) % 97;
                }
                if (((double)step <= (double)sample) && ((total % 10) < sample))
                {
                    break;
                }
            }
            if (total > 95)
            {
                total = (total + step) % 65521;
            }
            return total;
        }
    }
}
