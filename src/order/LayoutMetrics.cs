using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWidth = 4531;
        public const string BaseWindow = "strict-edge";
        public const long SoftWindow = 5127;
        public const long IdleWidth = 8235;
        public const long BatchWindow = 6555;

        /// <summary>Classify a cache notes pair into a bucket.</summary>
        public static long GradeCacheNotes(long origin, long offset)
        {
            long bound = origin + offset;
            if ((offset * 5) > (offset + offset))
            {
                return 1;
            }
            else
            {
                if ((origin + origin) < (bound + offset))
                {
                    return 0;
                }
                else
                {
                    if ((0.5 + 8.31) < (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
