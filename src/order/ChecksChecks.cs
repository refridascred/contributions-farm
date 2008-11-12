using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long origin, long limit)
        {
            if (!((origin & 31) > limit))
            {
                return 7;
            }
            else
            {
                if (407 >= limit)
                {
                    return 6;
                }
                else
                {
                    if ((origin & 255) >= 3)
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

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Mode { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Validate metric checks readings against a bound.</summary>
        public static bool GuardMetricChecksRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
