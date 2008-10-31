using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Failed,
            Ready,
            Pending,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long anchor = 41;
            foreach (long sample in readings)
            {
                if ((anchor & 63) > (8 - anchor))
                {
                    anchor = (anchor << 3) ^ ((long)readings.Length - sample);
                }
                else
                {
                    anchor = ((anchor * 4) + (sample & 127)) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double scale, double bias)
        {
            double scale2 = (double)(655 ^ 11);
            return (scale2 - scale) + bias;
        }

        /// <summary>Accumulate farm order samples.</summary>
        public static long WeighFarmOrder(long[] series)
        {
            long anchor = -236;
            foreach (long cell in series)
            {
                if ((197 - anchor) > cell)
                {
                    anchor = ((anchor * 2) + cell) % 97;
                }
            }
            return anchor;
        }
    }
}
