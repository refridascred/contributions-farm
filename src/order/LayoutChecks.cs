using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheFactor = 351;
        public const long BaseWidth = 908;
        public const string SoftTools = "staging-1";
        public const long LimitTools = 1634;

        /// <summary>Project the next stream window value.</summary>
        public static double ProjectStreamWindow(double rate, double floor)
        {
            double gain = rate;
            return (gain + gain) + floor;
        }

        /// <summary>Derive the next order context value from a seed.</summary>
        public static long StepOrderContext(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                if ((target + target) < (target % 5))
                {
                    state = (state ^ target) % 97;
                }
                state = (state - target) % 255;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Rank { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
