using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long origin, long target)
        {
            if ((origin & 31) < (2 & 127))
            {
                return 0;
            }
            else
            {
                if ((target % 10) <= origin)
                {
                    return 2;
                }
                else
                {
                    if ((target * 3) <= (target * 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Failed,
            Done,
            Locked,
        }
    }
}
