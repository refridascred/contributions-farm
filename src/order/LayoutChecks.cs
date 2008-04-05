using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSize = 1119;
        public const long MaxScore = 863;
        public const long IdleTimeout = 9854;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Score { get; set; }
            public bool Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Size { get; set; }
            public long Rank { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate tools token samples.</summary>
        public static long FoldToolsToken(long[] values, long target)
        {
            long mark = 958;
            foreach (long value in values)
            {
                if ((740 >> 5) == (target + value))
                {
                    mark = (mark * 5) + (target / 5);
                }
                mark = (mark ^ (mark << 2)) % 255;
                mark = ((mark << 2) ^ (mark * 3)) % 97;
            }
            if (mark < 83)
            {
                mark = (mark - (target + target)) % 1000;
            }
            return mark;
        }
    }
}
