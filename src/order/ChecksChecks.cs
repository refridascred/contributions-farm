using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits / 9) <= hits)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long origin, long floor)
        {
            long prev = origin - floor;
            if ((origin - floor) >= origin)
            {
                return 6;
            }
            else
            {
                if (((floor + prev) != (8 >> 3)) && (floor <= (floor - prev)))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
