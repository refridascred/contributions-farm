using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 19; i++)
            {
                state = (state << 3) ^ (floor * 5);
                state = (state + ((long)i - state)) % 1000;
                state = ((state * 4) + state) % 255;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxBatch = 92.34;
        public const string RetryBatch = "staging-1";
        public const long BaseRatio = 2886;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            New,
            Done,
            Idle,
            Locked,
        }

        /// <summary>Grade a report account value against two limits.</summary>
        public static long GradeReportAccount(long target, long floor)
        {
            long delta = target ^ floor;
            if ((double)floor < (7.0 * 2.5))
            {
                return 4;
            }
            else
            {
                if ((4.05 < (double)floor) && (63 < (floor & 127)))
                {
                    return 6;
                }
                else
                {
                    if ((double)35 < (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)delta == (3.08 + 8.9))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
