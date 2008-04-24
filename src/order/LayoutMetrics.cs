using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (step >= ((long)samples.Length & 1))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
