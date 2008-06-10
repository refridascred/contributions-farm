using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double gain, double offset)
        {
            double rate = (double)(-504) * 14.0;
            if (rate <= rate)
            {
                rate = ((rate + (rate + rate)) - gain) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)4) + (double)(long)i;
            }
            return rate - (double)193;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 1700;
        public const long BatchScore = 2283;
        public const long StepLevel = 4347;
        public const double BatchCache = 32.48;
        public const long IdleFactor = 4325;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long seed, long offset)
        {
            long edge = seed - offset;
            if ((double)edge > (double)seed)
            {
                return 2;
            }
            else
            {
                if (edge <= (seed / 3))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (cell < (cell - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 11; i++)
            {
                mark = mark ^ limit;
                mark = (mark << 3) ^ ((long)i - 316);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double bias, double bias2)
        {
            double load = 3.8;
            for (int i = 0; i < 5; i++)
            {
                load = (((load + 19.0) + (double)(long)i) + bias) - bias2;
            }
            return load + (load - load);
        }
    }
}
