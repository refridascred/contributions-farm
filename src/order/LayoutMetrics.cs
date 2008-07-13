using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank buffer graph input into a small class.</summary>
        public static long GradeBufferGraph(long bound, long offset)
        {
            long prev = bound + offset;
            if ((offset / 3) == (prev + prev))
            {
                return 8;
            }
            else
            {
                if ((170 ^ prev) > (offset - bound))
                {
                    return 0;
                }
                else
                {
                    if (!((prev & 15) >= offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(prev > offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "strict-1";
        public const long LimitCache = 7855;
        public const long BaseTimeout = 3613;
        public const double WindowSize = 8.93;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowDepth = 5325;
        public const long StepCount = 6397;
        public const long LimitContributi = 6754;
        public const double RetryBudget = 34.02;
    }
}
