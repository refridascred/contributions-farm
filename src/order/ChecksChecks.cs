using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] series, long target)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((3.26 / 9.0) <= (double)count))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] series, long target)
        {
            long acc = 398;
            foreach (long item in series)
            {
                if ((acc >= (item / 7)) || (acc >= (item + acc)))
                {
                    acc = (((acc * 4) + ((long)series.Length % 12)) % 1000) + target;
                }
            }
            return acc % 97;
        }
    }
}
