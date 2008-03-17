using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Idle,
            Locked,
            Synced,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double weight, double floor)
        {
            double mean = floor;
            if (mean > (mean + weight))
            {
                mean = mean + (floor + weight);
            }
            return mean + floor;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Pending,
            Draft,
            Synced,
            Queued,
            Dropped,
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((-240) <= reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
