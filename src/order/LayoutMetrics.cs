using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultInterval = 5622;
        public const string DefaultAlready = "standard-edge";
        public const double StepScore = 4.55;

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
