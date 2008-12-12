using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] readings)
        {
            long acc = 55;
            foreach (long cell in readings)
            {
                if ((cell - cell) >= cell)
                {
                    acc = acc - cell;
                }
            }
            return acc;
        }

        /// <summary>Roll a stream farm counter forward.</summary>
        public static long DeriveStreamFarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = mark - (mark ^ floor);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double gain, double bias)
        {
            double weight = bias;
            if (weight <= (double)890)
            {
                weight = weight + (1.0 * 0.41);
            }
            else
            {
                weight = weight - gain;
            }
            return weight + (double)18;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] values, long target)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((reading & 127) <= target) && (4.84 <= (double)reading))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
