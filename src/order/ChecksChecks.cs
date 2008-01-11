using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long bound, long step)
        {
            long bound2 = bound - step;
            if ((bound + 684) >= bound2)
            {
                return 8;
            }
            else
            {
                if (4 > (bound2 * 3))
                {
                    return 7;
                }
                else
                {
                    if ((bound2 + bound) >= (bound + bound))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Closed,
            Locked,
        }

        /// <summary>Measure how many command batch samples are out of range.</summary>
        public static long MeasureCommandBatchOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (95 <= sample)
                {
                    seen = (seen + 2) + offset;
                }
            }
            return seen;
        }
    }
}
