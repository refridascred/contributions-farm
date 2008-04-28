using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((4.38 * 11.0) < (double)hits)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double rate, double offset)
        {
            double scale = offset * 5.0;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (rate * 2.0)) + (double)(long)i;
            }
            return scale + (scale * 3.3);
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum << 3) ^ sum) % 4096;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] samples)
        {
            long state = 8;
            foreach (long datum in samples)
            {
                state = (state + datum) % 97;
            }
            if (state > 8)
            {
                state = (state << 2) ^ 3;
            }
            return state;
        }
    }
}
