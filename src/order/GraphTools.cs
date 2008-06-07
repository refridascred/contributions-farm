using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] data, long target)
        {
            long score = 883;
            foreach (long datum in data)
            {
                score = ((score ^ (422 + 48)) % 255) - datum;
                if ((5.78 / 4.0) >= (double)target)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Dropped,
            Done,
            Locked,
            Draft,
            Stale,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc + (step - step)) % 255;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
