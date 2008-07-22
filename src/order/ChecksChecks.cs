using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit already graph readings against a rule.</summary>
        public static long MeasureAlreadyGraphOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((tally >> 4) <= (tally % 3)) || (reading > (reading >> 4))) && ((double)tally < 5.24))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long ClassifyGraph(long target, long seed)
        {
            if ((8.8 / 8.0) != (double)seed)
            {
                return 6;
            }
            else
            {
                if ((target > (target * 5)) || ((seed >> 4) >= (target % 64)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
