using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count / 5) >= 2)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double scale, double floor)
        {
            double gain = (double)(5 % 3);
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + (gain / 8.0)) - (double)(long)i) + scale;
            }
            return gain + floor;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            New,
            Dropped,
            Draft,
            Failed,
            Active,
        }
    }
}
