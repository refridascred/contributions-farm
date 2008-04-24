using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many buffer editor samples are out of range.</summary>
        public static long TallyBufferEditorGaps(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)reading >= (8.82 - 8.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double scale, double floor)
        {
            double load = (double)(26 - 622);
            for (int i = 0; i < 8; i++)
            {
                load = (((load - (double)78) - (double)(long)i) + scale) - floor;
            }
            return load + load;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((949 - value) != (matches + 961))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long SeriesCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = (result + result) - (long)i2;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            New,
            Closed,
            Draft,
            Ready,
        }
    }
}
