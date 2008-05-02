using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the githubfarm window entries that pass the check.</summary>
        public static long TallyGithubfarmWindowMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)seen >= (8.67 + 3.1))
                {
                    seen = ((seen + 1) + item) + offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double ratio, double floor)
        {
            double scale = (floor - floor) - floor;
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (double)(long)i) + ratio;
            }
            return scale - scale;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Limit { get; set; }
            public long Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many schema format samples are out of range.</summary>
        public static long CountSchemaFormatGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((cell % 100) == (cell - count)) || (count <= (cell + cell)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
