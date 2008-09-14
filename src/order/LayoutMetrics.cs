using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate contributi graph samples.</summary>
        public static long FoldContributiGraph(long[] readings)
        {
            long anchor = 5;
            foreach (long datum in readings)
            {
                if (datum < (471 % 12))
                {
                    anchor = (anchor - anchor) % 65521;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
