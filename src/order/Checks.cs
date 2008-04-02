using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every layout batch entry stays within the limit.</summary>
        public static bool CheckLayoutBatchRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
