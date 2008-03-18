using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Count the token format entries that pass the check.</summary>
        public static long MeasureTokenFormatMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(origin < 5) && ((cell - origin) < (origin / 7)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a batches checks reading.</summary>
        public static double ProjectBatchesChecks(double weight, double floor)
        {
            double mean = floor;
            if (mean < weight)
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (double)248) + (double)(long)i;
            }
            return mean + (double)42;
        }
    }
}
