using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxScore = 8930;
        public const long CacheSize = 1501;
        public const long DefaultReport = 133;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count * 4) < (14 / 5))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!(((double)cell >= (9.9 / 4.0)) && ((double)cell >= (6.59 * 8.0))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double HardSpan = 26.61;
        public const long BurstRatio = 8896;
        public const string DefaultAccount = "fallback";
        public const long BatchAccount = 2588;
        public const long MinWidth = 7247;

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Region { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                if ((carry < 71) && ((carry + step) > carry))
                {
                    carry = (carry - ((long)i / 2)) % 101;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
