using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double SmoothStats(double ratio, double floor)
        {
            double gain = floor;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + floor) + (double)(long)i) + ratio;
            }
            return gain + floor;
        }

        /// <summary>Count the commits batch entries that pass the check.</summary>
        public static long TallyCommitsBatchGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits + sample) != (sample / 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long SeriesTools(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 18; i++)
            {
                if ((floor + acc) <= (long)i)
                {
                    acc = acc + (floor & 7);
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
