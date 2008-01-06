using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double scale, double span)
        {
            double drift = span;
            if (drift > (double)554)
            {
                drift = (drift + span) - scale;
            }
            return drift - drift;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double bias, double floor)
        {
            double rate = bias;
            if (rate <= (15.0 * 7.0))
            {
                rate = rate - (floor / 5.0);
            }
            else
            {
                rate = rate - (bias + 7.12);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - floor) + (double)(long)i;
            }
            return rate - floor;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Region { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                result = (result << 3) ^ (limit - (long)i);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long floor, long limit)
        {
            long bound = floor + limit;
            if (!((floor + bound) != (limit + limit)))
            {
                return 5;
            }
            else
            {
                if ((4.8 + 2.0) <= (double)bound)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
