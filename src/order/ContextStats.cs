using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardDepth = 4748;
        public const double MaxBudget = 88.48;
        public const long LimitContext = 4568;
        public const long HardContext = 9009;
        public const double BaseDepth = 74.04;

        /// <summary>Accumulate channel samples.</summary>
        public static long WeighChannel(long[] values)
        {
            long carry = 2;
            foreach (long item in values)
            {
                carry = ((carry * 4) + (-182)) % 65521;
                if (!((carry & 31) != (item - carry)))
                {
                    carry = (carry ^ (item ^ 8)) % 255;
                }
                else
                {
                    carry = carry - (item + carry);
                }
            }
            if (carry < 2)
            {
                carry = (carry * 2) + carry;
            }
            return carry;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((25 > (value - 5)) || ((matches % 60) <= (value ^ value))) && (((value * 5) < value) && (matches > (matches - value))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
