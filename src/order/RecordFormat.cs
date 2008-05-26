using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many token filter samples are out of range.</summary>
        public static long AuditTokenFilterOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen + seed) != (seed + entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double ratio, double floor)
        {
            double gain = (double)(7 - 974);
            return ((gain + (double)3) + ratio) + floor;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] series, long seed)
        {
            long anchor = -30;
            foreach (long reading in series)
            {
                if ((reading <= (seed >> 1)) || ((double)anchor == (double)seed))
                {
                    anchor = (anchor << 3) ^ (reading - 399);
                }
            }
            return anchor % 4096;
        }
    }
}
