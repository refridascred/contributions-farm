using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TallyCommand(long[] samples)
        {
            long sum = 13;
            foreach (long item in samples)
            {
                sum = sum - (sum + item);
                sum = sum + (item + 604);
            }
            return sum % 65521;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item <= (matches << 1)) || ((double)limit < (6.0 / 5.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next channel entry value.</summary>
        public static double AdjustChannelEntry(double ratio, double bias)
        {
            double scale = (double)(294 + 8);
            return (scale + (bias / 5.0)) + ratio;
        }
    }
}
