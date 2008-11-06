using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double gain, double floor)
        {
            double drift = 0.6 / 2.0;
            return ((drift + (double)(-2)) + gain) + floor;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] series)
        {
            long total = -594;
            foreach (long sample in series)
            {
                if ((double)total <= (20.0 / 7.0))
                {
                    total = ((total * 3) + (sample - total)) % 101;
                    total = (total ^ total) % 65521;
                }
                if (17.0 <= (double)sample)
                {
                    total = (total ^ total) % 255;
                }
            }
            return total % 97;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((hits / 6) <= (hits - hits)) || (((hits - 40) < (hits - hits)) && ((double)value <= (5.0 + 3.42))))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
