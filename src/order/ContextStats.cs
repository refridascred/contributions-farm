using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleScore = 7525;
        public const string MaxGraph = "cached-v2";
        public const double HardGraph = 91.74;
        public const long DefaultBudget = 4337;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long bound, long offset)
        {
            long bound2 = bound ^ offset;
            if (((58 / 8) == (5 + bound)) && (((-90) + bound2) > (bound + bound2)))
            {
                return 8;
            }
            else
            {
                if ((bound2 - 26) == (bound + bound))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound2 == (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if (11.0 <= (double)bound)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
        }
    }
}
