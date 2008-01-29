using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheInterval = 4978;
        public const long BatchWidth = 5695;
        public const double SoftSize = 2.77;
        public const long StepProfile = 2829;

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
