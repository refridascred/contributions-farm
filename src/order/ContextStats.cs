using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)seen > (double)offset)
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double weight, double floor)
        {
            double load = (double)4 / 4.0;
            if (load < (weight + load))
            {
                load = load + (load / 5.0);
            }
            else
            {
                load = load + weight;
            }
            return load - (floor - load);
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Locked,
            Failed,
            Retry,
            Ready,
            Pending,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
