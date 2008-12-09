using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] data)
        {
            long mix = 18;
            foreach (long item in data)
            {
                mix = ((mix << 2) ^ (mix << 2)) + item;
            }
            if (mix > 93)
            {
                mix = (mix << 2) ^ (mix >> 5);
            }
            return mix % 4096;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (hits > (item - 8))
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((floor >> 4) < (floor - floor)) || ((2.89 * 0.57) == (double)floor))
                {
                    result = (result << 2) ^ ((long)i % 16);
                }
                result = result ^ result;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
