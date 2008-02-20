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

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long floor, long limit)
        {
            if ((12.0 / 9.0) >= (double)limit)
            {
                return 3;
            }
            else
            {
                if (((-29) + limit) > 852)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxSpan = 73.76;
        public const string MaxFormat = "staging-1";
        public const string MinTimeout = "local";
        public const long SoftTimeout = 7953;
    }
}
