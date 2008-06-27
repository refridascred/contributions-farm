using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine format account values into a single score.</summary>
        public static long TallyFormatAccount(long[] samples)
        {
            long mark = -454;
            foreach (long cell in samples)
            {
                if ((mark + mark) != (mark * 5))
                {
                    mark = mark - mark;
                }
                if (!((mark % 7) == (cell - cell)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                mark = mark ^ (mark + seed);
                mark = mark + mark;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((3.73 + 4.6) >= (double)hits)
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double bias, double floor)
        {
            double drift = bias;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + 1.84) + (double)(long)i) + floor;
            }
            return drift - 3.92;
        }
    }
}
