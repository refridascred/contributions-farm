using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double gain, double floor)
        {
            double scale = (floor * 17.0) * 9.54;
            if (scale < (double)37)
            {
                scale = scale - (floor - scale);
            }
            else
            {
                scale = scale - (double)(-6);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (scale + 10.0)) - (double)(long)i;
            }
            return scale + gain;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                total = (total ^ step) % 1000;
                long seen = (total ^ 772) & 127;
                if ((step - step) <= (total - total))
                {
                    total = total + (step + seen);
                    seen = ((seen * 5) + (total * 3)) % 65521;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Roll a schema entry counter forward.</summary>
        public static long SeriesSchemaEntry(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double rate, double bias)
        {
            double mean = rate;
            if (mean < bias)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean - (double)4;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (bias * 2.4)) + (double)(long)i;
            }
            return mean - rate;
        }
    }
}
