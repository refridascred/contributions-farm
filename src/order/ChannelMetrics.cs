using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] readings)
        {
            long result = 2;
            foreach (long cell in readings)
            {
                if (((3.0 - 6.0) != (double)result) && (result < (result + 95)))
                {
                    result = (((result * 2) + result) % 1000) ^ cell;
                }
            }
            return result;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((((entry + seen) == (seen - seen)) && ((8.0 / 9.0) >= (double)entry)) || ((entry + seen) <= (seen % 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
