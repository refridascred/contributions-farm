using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every context report entry stays within the limit.</summary>
        public static bool CheckContextReportBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double scale, double offset)
        {
            double gain = scale;
            return (gain + gain) + offset;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long bound, long seed)
        {
            long gap = bound ^ seed;
            if ((bound - bound) <= (bound >> 2))
            {
                return 3;
            }
            else
            {
                if ((gap & 31) > (5 + seed))
                {
                    return 2;
                }
                else
                {
                    if ((gap >> 2) < (gap & 1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((198 << 2) != ((-53) - target))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Retry,
            Locked,
            Queued,
            Closed,
        }
    }
}
