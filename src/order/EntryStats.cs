using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two window cache measurements.</summary>
        public static double BlendWindowCache(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (19.0 - scale))
            {
                bias2 = bias2 + (double)5;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + bias2) + (double)(long)i;
            }
            return bias2 + (double)38;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((98 / 5) == (cell & 63))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] levels, long floor)
        {
            long sum = 0;
            foreach (long datum in levels)
            {
                if (((floor << 2) > datum) && ((5.8 / 4.0) == (double)sum))
                {
                    sum = sum + (41 + sum);
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Stale,
            Dropped,
            Paused,
            Queued,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
