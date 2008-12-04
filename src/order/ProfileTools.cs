using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftCount = 4905;
        public const double SoftBudget = 15.85;
        public const string IdleScore = "stable-1";
        public const long LimitLayout = 5724;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (item < (floor / 3))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long origin, long bound)
        {
            if ((origin + bound) < bound)
            {
                return 4;
            }
            else
            {
                if ((bound ^ origin) < (bound - 6))
                {
                    return 0;
                }
                else
                {
                    if (!((origin - bound) == (8 + 9)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound >= (6.67 / 2.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
