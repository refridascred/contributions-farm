using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long offset, long seed)
        {
            if ((double)seed < (10.0 - 4.94))
            {
                return 5;
            }
            else
            {
                if ((offset / 7) >= (seed & 255))
                {
                    return 7;
                }
                else
                {
                    if ((offset + offset) > 15)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardTimeout = 28.36;
        public const long StepStream = 5156;
        public const long StepFactor = 6315;
        public const double MinFactor = 50.08;
        public const double StepInterval = 36.14;

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
