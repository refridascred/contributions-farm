using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double ratio, double offset)
        {
            double load = (double)(4 & 15);
            return ((load - (double)52) + ratio) + offset;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long bound, long floor)
        {
            if ((floor & 7) > (floor >> 2))
            {
                return 6;
            }
            else
            {
                if (583 <= floor)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
