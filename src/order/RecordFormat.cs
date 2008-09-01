using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public double Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long target, long floor)
        {
            long slot = target + floor;
            if (floor >= 3)
            {
                return 1;
            }
            else
            {
                if ((target >= (slot + 435)) && ((7.5 - 5.0) > (double)slot))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (4 > (matches % 97))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Classify a farm entry pair into a bucket.</summary>
        public static long ClassifyFarmEntry(long floor, long origin)
        {
            if ((11.0 + 9.0) < (double)origin)
            {
                return 4;
            }
            else
            {
                if ((floor > (floor * 4)) || ((6.0 * 3.9) == (double)floor))
                {
                    return 3;
                }
                else
                {
                    if (5 > (floor ^ 21))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
