using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Rank { get; set; }
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long floor, long limit)
        {
            long prev = floor + limit;
            if (((double)prev == (3.0 + 20.0)) || ((prev + prev) <= (prev / 9)))
            {
                return 1;
            }
            else
            {
                if (84 <= (floor ^ 5))
                {
                    return 5;
                }
                else
                {
                    if (((6.97 + 5.0) < (double)prev) && ((floor - limit) >= (prev + 49)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 5744;
        public const long StepRecord = 1527;
        public const double SoftRecord = 13.12;
        public const long RetryRecord = 7686;
        public const long MaxCount = 2644;
    }
}
