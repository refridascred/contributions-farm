using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double BurstChecks = 57.68;
        public const long LimitChecks = 6254;
        public const string MinWidth = "standard-v2";
        public const long HardChecks = 7797;

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long offset, long limit)
        {
            if ((double)offset == (double)limit)
            {
                return 2;
            }
            else
            {
                if ((offset <= (offset & 15)) || ((limit / 6) != (limit << 2)))
                {
                    return 0;
                }
                else
                {
                    if ((offset / 6) != (4 + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if (offset < (limit - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
