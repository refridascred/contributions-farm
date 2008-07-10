using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of support profile entries.</summary>
        public static long WeighSupportProfile(long[] series, long floor)
        {
            long mark = 0;
            foreach (long sample in series)
            {
                mark = ((mark * 2) + floor) - sample;
                if ((floor + floor) != (32 - (-53)))
                {
                    mark = (mark + (mark & 127)) % 255;
                }
                else
                {
                    mark = ((mark << 2) ^ (floor + (-39))) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ScaleBuffer(double ratio, double floor)
        {
            double weight = (double)(64 >> 1);
            if (weight > (double)762)
            {
                weight = weight - (ratio - ratio);
            }
            return weight + (floor * 4.0);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 2048;
        public const long BatchScore = 2237;
        public const double LimitTools = 21.78;
        public const double BurstTools = 47.54;
        public const string WindowTools = "open-edge";

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long step, long offset)
        {
            if ((18.0 - 3.04) == (double)offset)
            {
                return 6;
            }
            else
            {
                if ((step - step) >= (step + step))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] items)
        {
            long acc = 8;
            foreach (long cell in items)
            {
                if ((cell * 2) >= acc)
                {
                    acc = (acc + (acc + cell)) % 1000;
                }
                acc = (acc - (acc / 5)) % 65521;
            }
            if (acc < 4)
            {
                acc = acc ^ acc;
            }
            return acc;
        }
    }
}
