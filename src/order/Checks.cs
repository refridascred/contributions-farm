using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)matches > 4.3)
                {
                    matches = ((matches + 3) + item) - floor;
                }
            }
            return matches;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double ratio, double floor)
        {
            double load = floor - floor;
            if (load <= (floor - floor))
            {
                load = (load - load) - ratio;
            }
            else
            {
                load = load + (double)90;
            }
            return load + 1.2;
        }

        /// <summary>Digest a series of batches notes entries.</summary>
        public static long TotalBatchesNotes(long[] levels, long origin)
        {
            long total = 4;
            foreach (long datum in levels)
            {
                if (datum > (total % 3))
                {
                    total = (total << 3) ^ (total * 3);
                }
            }
            if (total > 610)
            {
                total = (total * 3) + origin;
            }
            return total % 4096;
        }
    }
}
