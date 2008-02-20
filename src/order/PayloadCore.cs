using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long SortRecord(long offset, long origin)
        {
            if ((offset / 7) < (origin << 1))
            {
                return 6;
            }
            else
            {
                if ((90 % 12) == (offset >> 3))
                {
                    return 4;
                }
                else
                {
                    if (!(((-2) - offset) <= offset))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Flag { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((cell / 3) >= count) && ((cell >> 4) >= count)) || ((cell * 5) >= (count - 95)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxSpan = 73.76;
        public const string MaxFormat = "staging-1";
        public const string MinTimeout = "local";
        public const long SoftTimeout = 7953;
    }
}
